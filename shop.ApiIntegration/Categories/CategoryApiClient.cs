using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Categories;

namespace shop.ApiIntegration.Categories;

public class CategoryApiClient : BaseApiClient, ICategoryApiClient
{
    public CategoryApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
    {
    }

    public async Task<List<CategoryVm>> GetAll()
    {
        string apiURL = "/api/Categories/";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<CategoryVm>>(apiData);
        return result;
    }

    public async Task<CategoryVm> GetById(Guid id)
    {
        string apiURL = $"/api/Categories/{id}";
        var response = await _httpClient.GetAsync(apiURL);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<CategoryVm>(apiData);
        return result;
    }
}
