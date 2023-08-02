using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Common;
using System.Text;

namespace shop.ApiIntegration.Promotions
{
    public class PromotionApiClient : BaseApiClient, IPromotionApiClient
    {
        public PromotionApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

        public async Task<bool> CreatePromotion(PromotionCreateRequest collection)
        {
            string apiURL = "/api/Promotions/create";
            var json = JsonConvert.SerializeObject(collection);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiURL, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<PagedResult<PromotionVM>> GetAll(PromotionPagingRequest request)
        {
            string apiURL = $"/api/Promotions?Status={request.Status}&PromotionCode={request.PromotionCode}&PageIndex={request.PageIndex}&PageSize={request.PageSize}&KeyWord={request.KeyWord}";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<PagedResult<PromotionVM>>(apiData);
            return result;
        }

        public async Task<PromotionVM> GetById(Guid id)
        {
            string apiURL = $"/api/Promotions/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<PromotionVM>(apiData);
            return result;
        }

        public async Task<bool> UpdatePromotion(PromotionUpdateRequest collection)
        {
            string apiURL = $"/api/Promotions/update/{collection.Id}";
            var json = JsonConvert.SerializeObject(collection);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(apiURL, content);
            return response.IsSuccessStatusCode;
        }
    }
}
