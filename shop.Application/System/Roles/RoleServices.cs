using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shop.Data.Entities;
using shop.ViewModels.System.Roles;

namespace shop.Application.System.Roles
{
    public class RoleServices
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleServices(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }


        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();

            return roles;
        }
    }
}
