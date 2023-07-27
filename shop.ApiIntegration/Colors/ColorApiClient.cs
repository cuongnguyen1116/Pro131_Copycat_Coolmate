using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Colors
{
    public class ColorApiClient : BaseApiClient, IColorApiClient
    {
        public ColorApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

        public async Task<bool> CreateColor(ColorCreateRequest collection)
        {
            string apiURL = "/api/Colors/create";
            var json = JsonConvert.SerializeObject(collection);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiURL, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteColor(ColorDeleteRequest collection)
        {
            string apiURL = $"/api/Colors/delete/{collection.Id}";
            var response = await _httpClient.DeleteAsync(apiURL);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<ColorVm>> GetAll()
        {
            string apiURL = "/api/Colors/";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<ColorVm>>(apiData);
            return result;
        }

        public async Task<ColorVm> GetById(Guid id)
        {
            string apiURL = $"/api/Colors/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ColorVm>(apiData);
            return result;
        }

        public async Task<bool> UpdateColor(ColorUpdateRequest collection)
        {
            string apiURL = $"/api/Colors/update/{collection.Id}";
            var json = JsonConvert.SerializeObject(collection);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(apiURL, content);
            return response.IsSuccessStatusCode;
        }
    }
}
