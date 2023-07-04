using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;

namespace shop.ApiIntegration.Orders
{
    public class OrderApiClient : BaseApiClient, IOrderApiClient
    {
        public OrderApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

        public async Task<List<OrderVm>> GetAll()
        {
            string apiUrl = "/api/orders";

            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderVm>>(apiData);

            return result;
        }

        public async Task<List<OrderVm>> GetOrdersByStatus(OrderStatus status)
        {
            string apiUrl = $"/api/Orders/get-orders-by-status/{status}";

            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderVm>>(apiData);

            return result;
        }

        public async Task<List<OrderDetailVm>> GetOrderDetails(Guid id)
        {
            string apiUrl = $"/api/orders/get-order-details/{id}";

            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderDetailVm>>(apiData);

            return result;
        }

        public async Task<bool> ConfirmOrder(Guid id)
        {
            string apiUrl = $"/api/orders/confirm-order/{id}";
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }

        public async Task<bool> CompleteOrder(Guid id)
        {
            string apiUrl = $"/api/orders/complete-order/{id}";

            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);

            return result;
        }

        public async Task<bool> CancelOrder(Guid id)
        {
            string apiUrl = $"/api/orders/cancel-order/{id}";

            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);

            return result;
        }
    }
}
