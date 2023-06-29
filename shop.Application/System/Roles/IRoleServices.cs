using shop.ViewModels.System.Roles;

namespace shop.Application.System.Roles
{
    public interface IRoleServices
    {
        Task<List<RoleVm>> GetAll();

    }
}
