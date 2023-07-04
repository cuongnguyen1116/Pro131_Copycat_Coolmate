using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;

namespace shop.ApiIntegration.Orders
{
    public interface IOrderApiClient
    {
        Task<List<OrderVm>> GetAll();
        Task<List<OrderVm>> GetOrdersByStatus(OrderStatus status);
        Task<List<OrderDetailVm>> GetOrderDetails(Guid id);
        Task<bool> ConfirmOrder(Guid id);
        Task<bool> CompleteOrder(Guid id);
        Task<bool> CancelOrder(Guid id);
    }
}
