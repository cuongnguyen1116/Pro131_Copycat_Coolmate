using shop.ViewModels.Common;
using shop.ViewModels.System.Users;

namespace shop.ApiIntegration.Users;

public interface IUserApiClient
{
    Task<PagedResult<List<UserVm>>> GetUserPaging(GetUserPagingRequest request);
}
