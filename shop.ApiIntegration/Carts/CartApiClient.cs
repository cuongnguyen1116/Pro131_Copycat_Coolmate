using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.ApiIntegration.Categories;
using shop.ViewModels.Catalog.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Carts
{
    public class CartApiClient : BaseApiClient, ICartApiClient
    {
        public CartApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

        public async Task<ShowCartResult> ShowCart(Guid id)
        {
            string apiUrl = $"/api/Carts/ShowCart?id={id}";
            var response = await _httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ShowCartResult>(apiData);
            return result;
        }

        public async Task<bool> AddToCart(Guid userId, Guid productId, Guid sizeId, int quantity)
        {
            string apiUrl = $"/api/Carts/AddToCart?userId={userId}&productId={productId}&sizeId={sizeId}&quantity={quantity}";
            var response = await _httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }

        public async Task<CheckOutVm> CheckOut(Guid userId)
        {
            string apiUrl = $"/api/Carts/CheckOut?userId={userId}";
            var response = await _httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CheckOutVm>(apiData);
            return result;
        }

        public async Task<bool> PlaceOrder(Guid userId, string shipName, string shipPhoneNumber, string shipAddress)
        {
            string apiUrl = $"/api/Carts/PlaceOrder?userId={userId}&shipName={shipName}&shipPhoneNumber={shipPhoneNumber}&shipAddress={shipAddress}";
            var response = await _httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }
    }
}
