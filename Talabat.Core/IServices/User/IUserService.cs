﻿namespace Talabat.Core.IServices.User
{
    public interface IUserService
    {
        // For admin
        Task<IList<UserResponse>> GetUsersAsync(bool IncludeDeleted = false);
        Task<UserResponse> GetUserByIdAsync(int id);
        Task<UserResponse> CreateUserAsync(UserRequest request);
        Task<UserResponse> UpdateUserAsync(int id,UserRequest request);
        Task DeleteUserAsync(int id);
        Task UnLock(int id);
       
        // for user
        Task<UserProfileResponse> GetUserProfileAsync(string userId);
        Task UpdateUserProfile(string userId, UpdateUserProfile updateUserProfile);
        Task ChangeEmail(ChangeEmailRequest changeEmailRequest);
        Task ChangePasswordAsync(string userId,ChangePasswordRequest changePasswordRequest);
    }
}
