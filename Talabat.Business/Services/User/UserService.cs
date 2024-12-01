﻿namespace Talabat.Business.Services.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppIdentityDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public UserService(UserManager<ApplicationUser> userManager, IMapper mapper, AppIdentityDbContext context, IRoleService roleService, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _context = context;
            _roleService = roleService;
            _signInManager = signInManager;
        }

        #region get users without roles that belong them
        //public async Task<IList<UserResponse>> GetUsersAsync(bool IncludeDeleted = false)
        //{
        //    var query = _userManager.Users.AsQueryable();

        //    if (!IncludeDeleted)
        //    {
        //        query = query.Where(x => !x.IsDeleted);
        //    }

        //    var users = await query.Select(x => new UserResponse
        //    {
        //        Id = x.Id,
        //        FirstName = x.FirstName,
        //        LastName = x.LastName,
        //        Email = x.Email!
        //    })
        //        .ToListAsync();

        //    if (users is null)
        //        throw new ItemNotFound("Not Exist Users");

        //    return users;
        //}
        #endregion

        #region get users with roles that belong them 
        public async Task<IList<UserResponse>> GetUsersAsync(bool IncludeDeleted = false)
        {
            var query = _context.Users.AsQueryable();

            if (!IncludeDeleted)
            {
                query = query.Where(x => !x.IsDeleted);
            }

            var users = await (from u in query
                              select new UserResponse
                              {
                                  Id = u.Id,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  Email = u.Email!,
                                  IsDisabled = u.IsDisabled,
                                  Roles = (from ur in _context.UserRoles
                                           join r in _context.Roles
                                           on ur.RoleId equals r.Id
                                           where ur.UserId == u.Id
                                           select r.Name).ToList()!
                              })
                              .ToListAsync();

            if (users is null)
                throw new ItemNotFound("Not Exist Users");

            return users;
        }
        #endregion

        #region get users with roles that belong them with another implementaion but talk database so much to execute query while join talk to database once.
        public async Task<IList<UserResponse>> GetUsersAsync2(bool IncludeDeleted = false)
        {
            var query = _context.Users.AsQueryable();

            if (!IncludeDeleted)
            {
                query = query.Where(x => !x.IsDeleted);
            }

            var users = await query.ToListAsync();
            var list = new List<UserResponse>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                
                list.Add(new UserResponse
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email!,
                    IsDisabled = user.IsDisabled,
                    Roles = roles
                });
            }

            if (users is null)
                throw new ItemNotFound("Not Exist Users");

            return list;
        }
        #endregion

        #region get user by Id without roles that has it.
        //public async Task<UserResponse> GetUserByIdAsync(int id)
        //{
        //    var user = await _userManager.Users.Select(x => new UserResponse
        //    {
        //        Id = x.Id,
        //        FirstName = x.FirstName,
        //        LastName = x.LastName,
        //        Email = x.Email!
        //    })
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (user is null)
        //        throw new ItemNotFound("Not Exist User");

        //    return user;
        //}
        #endregion

        #region get user by Id with roles that has it.
        public async Task<UserResponse> GetUserByIdAsync(int id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
                throw new ItemNotFound("User does not exist");

            var roles = await _userManager.GetRolesAsync(user!);

            return new UserResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email!,
                IsDisabled = user.IsDisabled,
                Roles = roles
            };
        }
        #endregion

        #region get user by Id with roles that has it with another implementaion.
        public async Task<UserResponse> GetUserByIdAsync2(int id)
        {
            var user = await (from u in _context.Users
                              where u.Id == id
                              select new UserResponse
                              {
                                  Id = u.Id,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  Email = u.Email!,
                                  IsDisabled = u.IsDisabled,
                                  Roles = (from ur in _context.UserRoles
                                           join r in _context.Roles
                                           on ur.RoleId equals r.Id
                                           where ur.UserId == u.Id
                                           select r.Name).ToList()!
                              })
                              .FirstOrDefaultAsync();

            if (user is null)
                throw new ItemNotFound("User does not exist");

            return user;
        }
        #endregion

        #region Create User
        public async Task<UserResponse> CreateUserAsync(UserRequest request)
        {
            if (request is null)
                throw new BadRequest("Data can't be null");

            var emailExist = await _userManager.Users.AnyAsync(u => u.Email == request.Email);

            if(emailExist)
                throw new ItemAlreadyExist("Email already exist");

            var allowedRoles = await _roleService.GetRolesAsync();

            if (request.Roles.Except(allowedRoles.Select(x => x.Name)).Any())
            {
                throw new BadRequest("Invalid Roles Sended");
            }

            var user = _mapper.Map<ApplicationUser>(request);
            user.UserName = request.Email.Split('@')[0];

            var result = await _userManager.CreateAsync(user, request.Password);
            
            if (!result.Succeeded)
            {
                var error = result.Errors.Select(x => x.Description).FirstOrDefault() ?? "Error happens during Creation";

                throw new BadRequest(error);
            }

            if(request.Roles is not null && request.Roles.Any())
            {
                var identityResult = await _userManager.AddToRolesAsync(user, request.Roles);

                if (!identityResult.Succeeded)
                {
                    var error = identityResult.Errors.Select(x => x.Description).FirstOrDefault() ?? "Failed to add roles.";

                    throw new BadRequest(error);
                }
            }
           
            var userResponse = _mapper.Map<UserResponse>(user);
            userResponse.Roles = request.Roles ?? new List<string>();

            return userResponse;   
        }
        #endregion

        #region Update Exist User
        public async Task<UserResponse> UpdateUserAsync(int id, UserRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user is null)
                throw new ItemNotFound("User not found");

            if (request is null)
                throw new BadRequest("Data can't be null");

            var allowedRoles = await _roleService.GetRolesAsync();

            if (request.Roles.Except(allowedRoles.Select(x => x.Name)).Any())
            {
                throw new BadRequest("Invalid Roles sended");
            }

            var appUser = _mapper.Map(request, user);
            appUser.UserName = request.Email.Split('@')[0];

            var result = await _userManager.UpdateAsync(appUser);

            if (!result.Succeeded)
            {
                var error = result.Errors.Select(x=> x.Description).FirstOrDefault() ?? "Error happens";

                throw new BadRequest(error);
            }

            if(request.Roles is not null && request.Roles.Any())
            {
                await _context.UserRoles.Where(x => x.UserId == user.Id).ExecuteDeleteAsync();

                var identityResult = await _userManager.AddToRolesAsync(user, request.Roles);

                if (!identityResult.Succeeded)
                {
                    var error = identityResult.Errors.Select(x => x.Description).FirstOrDefault() ?? "Error happens";

                    throw new BadRequest(error);
                }
            }

            var userResponse = _mapper.Map<UserResponse>(appUser);
            userResponse.Roles = request.Roles ?? new List<string>();

            return userResponse;
        }
        #endregion

        #region Delete User
        public async Task DeleteUserAsync(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user is null)
                throw new ItemNotFound("User not found");

            user.IsDeleted = !user.IsDeleted;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                var error = result.Errors.FirstOrDefault();

                throw new BadRequest(error!.Description ?? "Error happens");
            }
        }
        #endregion

        #region Unlock User
        public async Task UnLock(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user is null)
                throw new ItemNotFound("User not found");

            var result = await _userManager.SetLockoutEndDateAsync(user, null);

            if (!result.Succeeded)
            {
                var error = result.Errors.Select(x=> x.Description).FirstOrDefault() ?? "Error occurs";

                throw new BadRequest(error);
            }
        }

        #endregion

        public async Task<UserProfileResponse> GetUserProfileAsync(string userId)
        {
            var user = await _context.Users.Where(x=> x.Id.ToString() == userId).Select(u=> new UserProfileResponse
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email!,
                PhoneNumber = u.PhoneNumber!
            })
                .FirstOrDefaultAsync();

           // I did't add validation to check exist user, because I am make sure that will handle this method that already authorized..

            return user!;
        }


        public async Task UpdateUserProfile(string userId, UpdateUserProfile updateUserProfile)
        {

            // I did't add validation to check exist user, because I am make sure that will handle this method that already authorized..


            await _userManager.Users.Where(x => x.Id.ToString() == userId)
                .ExecuteUpdateAsync(setters =>
                setters
                .SetProperty(p => p.FirstName, updateUserProfile.FirstName)
                .SetProperty(p => p.LastName, updateUserProfile.LastName)
                .SetProperty(p => p.PhoneNumber, updateUserProfile.PhoneNumber)
                );

            // Probability to failed is very small..
        }

        public async Task ChangeEmail(ChangeEmailRequest changeEmailRequest)
        {
            throw new Exception();
        }

        public async Task ChangePasswordAsync(string userId, ChangePasswordRequest changePasswordRequest)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            // I did't add validation to check exist user, because I am make sure that will handle this method that already authorized..

            var result = await _userManager.ChangePasswordAsync(user!, changePasswordRequest.CurrentPassword,changePasswordRequest.NewPassword);

            if(!result.Succeeded)
            {
                throw new BadRequest(string.Join(",", result.Errors.Select(x => x.Description).ToList()));
            }

            await _signInManager.RefreshSignInAsync(user!);
        }
    }
}

