using shop.ViewModels.System.Users;

namespace shop.Application.System.Users;

public interface IUserServices
{
    Task<string> Authencate(LoginRequest request);
    Task<bool> Register(RegisterRequest request);
    Task<bool> Update(Guid id, UserUpdateRequest request);
    Task<List<UserVm>> GetAll();
    Task<UserVm> GetById(Guid id);
    Task<bool> Delete(Guid id);
    Task<bool> RoleAssign(Guid id, RoleAssignRequest request);
}
