using Newtonsoft.Json;
using shop.ViewModels.Catalog.Sizes;

namespace shop.ApiIntegration.Sizes
{
    public class SizesApiClient : ISizesApiClient
    {
        public async Task<List<SizeVm>> GetAll()
        {
            var httpClient = new HttpClient();
            string apiURL = "https://localhost:5001/api/Sizes/";

            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<SizeVm>>(apiData);
            return result;
        }

        public async Task<SizeVm> GetById(Guid id)
        {
            var httpClient = new HttpClient();

            string apiURL = $"https://localhost:5001/api/Sizes/{id}";
            var response = await httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SizeVm>(apiData);
            return result;
        }
    }
}
