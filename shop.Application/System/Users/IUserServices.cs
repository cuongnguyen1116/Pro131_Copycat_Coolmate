using shop.ViewModels.Common;
using shop.ViewModels.System.Users;

namespace shop.Application.System.Users;

public interface IUserServices
{
    Task<ApiResult<string>> Authencate(LoginRequest request);

    Task<ApiResult<bool>> Register(RegisterRequest request);

    Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
    Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    Task<UserVm> GetById(Guid id);
    Task<ApiResult<bool>> Delete(Guid id);

    Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
}
