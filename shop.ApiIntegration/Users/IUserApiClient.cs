using shop.ViewModels.Common;
using shop.ViewModels.System.Users;

namespace shop.ApiIntegration.Users;

public interface IUserApiClient
{
    Task<ApiResult<string>> Authenticate(LoginRequest request);
    Task<PagedResult<UserVm>> GetUserPaging(GetUserPagingRequest request);
    Task<PagedResult<UserVm>> GetCustomerPaging(GetUserPagingRequest request);
    Task<ApiResult<bool>> RegisterEmployee(RegisterRequest registerRequest);
    Task<ApiResult<bool>> RegisterCustomer(RegisterRequest registerRequest);
    Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);
    Task<ApiResult<string>> AuthenticateCustomer(LoginRequest request);
    Task<ApiResult<bool>> DeleteUser(Guid id);
    Task<ApiResult<UserVm>> GetById(Guid id);
}
