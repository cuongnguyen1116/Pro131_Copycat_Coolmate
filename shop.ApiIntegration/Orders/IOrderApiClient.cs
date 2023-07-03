using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;

namespace shop.ApiIntegration.Orders
{
    public interface IOrderApiClient
    {
        Task<List<OrderVm>> GetAll();
        Task<List<OrderVm>> GetOrderByStatus(OrderStatus status);
        Task<List<OrderDetailVm>> GetOrderDetails(Guid id);
    }
}
