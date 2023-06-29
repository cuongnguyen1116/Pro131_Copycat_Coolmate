using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using shop.Data.Entities;
using shop.ViewModels.System.Users;

namespace shop.Application.System.Users
{
    public class UserServices : IUserServices
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;

        public Task<string> Authencate(LoginRequest request)
        {
            return null;
        }
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVm>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserVm> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RoleAssign(Guid id, RoleAssignRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Guid id, UserUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
