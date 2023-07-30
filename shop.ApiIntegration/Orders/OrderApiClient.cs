using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.ApiIntegration.Orders;

public class OrderApiClient : BaseApiClient, IOrderApiClient
{
    public OrderApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
    {
    }

    // slug: /api/Orders/get-orders-paging?Status=0&KeyWord=23&PageIndex=1&PageSize=10
    public async Task<PagedResult<OrderVm>> GetOrdersPaging(OrderPagingRequest request)
    {
        string apiUrl = $"/api/Orders/get-orders-paging?Status={request.Status}&KeyWord={request.KeyWord}&PageIndex={request.PageIndex}&PageSize={request.PageSize}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<PagedResult<OrderVm>>(apiData);
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

    public async Task<ApiResult<bool>> ConfirmAllOrder()
    {
        string apiUrl = "/api/orders/confirm-all-order";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResult<bool>>(apiData);
        return result;
    }

    public async Task<ApiResult<bool>> ConfirmOrder(Guid id)
    {
        string apiUrl = $"/api/orders/confirm-order/{id}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResult<bool>>(apiData);
        return result;
    }

    public async Task<ApiResult<bool>> GetOrderToShipper(Guid id)
    {
        string apiUrl = $"/api/orders/get-order-to-shipper/{id}";
        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResult<bool>>(apiData);
        return result;
    }

    public async Task<ApiResult<bool>> CompleteOrder(Guid id)
    {
        string apiUrl = $"/api/orders/complete-order/{id}";

        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResult<bool>>(apiData);

        return result;
    }

    public async Task<ApiResult<bool>> CancelOrder(Guid id)
    {
        string apiUrl = $"/api/orders/cancel-order/{id}";

        var response = await _httpClient.GetAsync(apiUrl);
        response.EnsureSuccessStatusCode();
        string apiData = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResult<bool>>(apiData);

        return result;
    }
}
