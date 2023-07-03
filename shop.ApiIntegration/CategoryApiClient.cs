using Newtonsoft.Json;
using shop.Data.Entities;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration
{
    public class CategoryApiClient : ICategoryApiClient
    {
        public CategoryApiClient() { }
        public async Task<List<CategoryVm>> GetAll()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5000/api/Categories/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<CategoryVm>>(apiData);
            return result;
        }

        public async Task<CategoryVm> GetById(Guid id)
        {
            var httpClient = new HttpClient();

            string apiURL = $"https://localhost:5000/api/Categories/{id}";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CategoryVm>(apiData);
            return result;
        }
    }
}
