
using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CASolution.Application.Contracts.Authorization
{
    public interface IUserRoleService
    {
        Task<bool> IsInRoleAsync(int userId, string roleName);
        Task<Result<List<Role>>> GetUserRolesAsync(string email);
        Task<Result> AssignUserToRole(string email, string roleName);
        Task<Result> RemoveUserFromRole(string email, string roleName);
    }

}
