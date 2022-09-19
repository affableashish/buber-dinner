using BuberDinner.Application.Common.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(AppIdentityResult Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<AppIdentityResult> DeleteUserAsync(string userId);
    }
}
