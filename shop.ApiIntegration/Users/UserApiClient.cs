using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Common;
using shop.ViewModels.System.Users;
using System.Text;

namespace shop.ApiIntegration.Users;

public class UserApiClient : BaseApiClient, IUserApiClient
{
    private readonly IHttpContextAccessor _contextAccessor;



    public UserApiClient(HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(httpClient, configuration)
    {
        _contextAccessor = httpContextAccessor;

    }

    public async Task<ApiResult<string>> Authenticate(LoginRequest request)
    {

        string url = $"/api/Users/authenticate";
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, httpContent);
        string result = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(result);
        }

        return JsonConvert.DeserializeObject<ApiErrorResult<string>>(result);

    }
    public async Task<ApiResult<string>> AuthenticateCustomer(LoginRequest request)
    {

        string url = $"/api/Users/authenticate-customer";
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, httpContent);
        string result = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(result);
        }

        return JsonConvert.DeserializeObject<ApiErrorResult<string>>(result);

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
    public async Task<PagedResult<UserVm>> GetCustomerPaging(GetUserPagingRequest request)
    {
        string apiUrl = $"/api/Users/get-customer-paging?KeyWord={request.Keyword}&PageIndex={request.PageIndex}&PageSize={request.PageSize}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<PagedResult<UserVm>>(apiData);
        return result;
    }
    public async Task<ApiResult<UserVm>> GetById(Guid id)
    {
        //var sessions = _httpContext.Session.GetString("Token");
        string apiUrl = $"/api/Users/get-by-id/{id}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<ApiSuccessResult<UserVm>>(apiData);

        return JsonConvert.DeserializeObject<ApiErrorResult<UserVm>>(apiData);
    }

    public async Task<ApiResult<bool>> RegisterEmployee(RegisterRequest registerRequest)
    {
        string url = "/api/Users/registeremployee";
        var json = JsonConvert.SerializeObject(registerRequest);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        string result = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

        return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
    }

    public async Task<ApiResult<bool>> RegisterCustomer(RegisterRequest registerRequest)
    {
        string url = "/api/Users/registercustomer";
        var json = JsonConvert.SerializeObject(registerRequest);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        string result = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

        return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
    }

    public Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResult<bool>> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

}
