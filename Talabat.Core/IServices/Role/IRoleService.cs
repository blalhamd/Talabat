﻿namespace Talabat.Core.IServices.Role
{
    public interface IRoleService
    {
        Task<IList<RoleResponse>> GetRolesAsync(bool IncludeDeleted = false);
        Task<RoleResponse> GetRoleByIdAsync(int id);
        Task<RoleResponse> AddRoleAsync(RoleRequest request);
        Task<RoleResponse> EditRoleAsync(int id,RoleRequest request);
        Task DeleteRoleAsync(int id);
    }
}
