using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.Data.Enums;
using shop.Utilities.Constants;
using shop.ViewModels.Catalog.Orders;

namespace shop.ApiIntegration.Orders
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly IConfiguration _configuration;

        public OrderApiClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<OrderVm>> GetAll()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = "/api/orders";

            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderVm>>(apiData);

            return result;
        }

        public async Task<List<OrderVm>> GetOrderByStatus(OrderStatus status)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = $"/api/Orders/get-order-by-status/{status}";

            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderVm>>(apiData);

            return result;
        }

        public async Task<List<OrderDetailVm>> GetOrderDetails(Guid id)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = $"/api/orders/get-order-details/{id}";
            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<OrderDetailVm>>(apiData);
            return result;
        }

        public async Task<bool> ConfirmOrder(Guid id)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = $"/api/orders/confirm-order/{id}";
            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }

        public async Task<bool> CompleteOrder(Guid id)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = $"/api/orders/complete-order/{id}";
            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }

        public async Task<bool> CancelOrder(Guid id)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress])
            };
            string apiUrl = $"/api/orders/cancel-order/{id}";
            var response = await httpClient.GetAsync(apiUrl);
            string apiData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<bool>(apiData);
            return result;
        }
    }
}
