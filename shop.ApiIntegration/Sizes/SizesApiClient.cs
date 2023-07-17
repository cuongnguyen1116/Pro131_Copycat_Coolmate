using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Sizes
{
    public class SizesApiClient : BaseApiClient, ISizesApiClient
    {
        public SizesApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

public class SizesApiClient : ISizesApiClient
{
    public async Task<List<SizeVm>> GetAll()
    {
            string apiURL = "/api/Sizes/";
            var response = await _httpClient.GetAsync(apiURL);
            response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<SizeVm>>(apiData);
        return result;
    }

    public async Task<SizeVm> GetById(Guid id)
    {
            string apiURL = $"/api/Sizes/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<SizeVm>(apiData);
        return result;
    }
}
}
