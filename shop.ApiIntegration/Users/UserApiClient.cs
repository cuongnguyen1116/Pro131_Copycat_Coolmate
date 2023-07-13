using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Common;
using shop.ViewModels.System.Users;

namespace shop.ApiIntegration.Users;

public class UserApiClient : BaseApiClient, IUserApiClient
{
    private readonly IHttpContextAccessor _contextAccessor;

    public UserApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
    {
    }

    public async Task<ApiResult<bool>> Authencate(LoginRequest loginRequest)
    {
        //var session = _contextAccessor.HttpContext.Session.getstring()
        return null;
    }

    public async Task<PagedResult<UserVm>> GetUserPaging(GetUserPagingRequest request)
    {
        string apiUrl = $"/api/Users/get-staff-paging?KeyWord={request.Keyword}&PageIndex={request.PageIndex}&PageSize={request.PageSize}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<PagedResult<UserVm>>(apiData);
        return result;
    }

    public async Task<UserVm> GetById(Guid id)
    {
        string apiUrl = $"/api/Users/get-by-id/{id}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<UserVm>(apiData);
        return result;
    }
}
