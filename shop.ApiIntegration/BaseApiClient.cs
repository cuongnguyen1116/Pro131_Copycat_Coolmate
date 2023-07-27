using Microsoft.Extensions.Configuration;
using shop.Utilities.Constants;

namespace shop.ApiIntegration;

public class BaseApiClient
{
    protected readonly HttpClient _httpClient;
    protected readonly IConfiguration _configuration;

    public BaseApiClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _httpClient.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
    }
}
