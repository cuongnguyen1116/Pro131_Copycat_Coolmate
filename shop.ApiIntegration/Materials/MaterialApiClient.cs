using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Materials;
using System.Text;

namespace shop.ApiIntegration.Materials;

public class MaterialApiClient : BaseApiClient, IMaterialApiClient
{
    public MaterialApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
    {
    }
    public async Task<bool> CreateMaterial(MaterialCreateRequest collection)
    {
        string apiURL = "/api/Materials/create";
        var json = JsonConvert.SerializeObject(collection);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(apiURL, content);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteMaterial(MaterialDeleteRequest collection)
    {
        string apiURL = $"/api/Materials/delete/{collection.Id}";
        var response = await _httpClient.DeleteAsync(apiURL);
        return response.IsSuccessStatusCode;
    }

    public async Task<List<MaterialVm>> GetAll()
    {
        string apiURL = "/api/Materials/";
        var response = await _httpClient.GetAsync(apiURL);
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<MaterialVm>>(apiData);
        return result;
    }

    public async Task<MaterialVm> GetById(Guid id)
    {
        string apiURL = $"/api/Materials/{id}";
        var response = await _httpClient.GetAsync(apiURL);
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<MaterialVm>(apiData);
        return result;
    }

    public async Task<bool> UpdateMaterial(MaterialUpdateRequest collection)
    {
        string apiURL = $"/api/Materials/update/{collection.Id}";
        var json = JsonConvert.SerializeObject(collection);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync(apiURL, content);
        return response.IsSuccessStatusCode;
    }
}
