using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.ApiIntegration.Orders
{
    public interface IOrderApiClient
    {
        Task<List<OrderVm>> GetOrdersByStatus(OrderStatus status);
        Task<List<OrderDetailVm>> GetOrderDetails(Guid id);
        Task<ApiResult<bool>> ConfirmOrder(Guid id);
        Task<ApiResult<bool>> GetOrderToShipper(Guid id);
        Task<ApiResult<bool>> CompleteOrder(Guid id);
        Task<ApiResult<bool>> CancelOrder(Guid id);
    }
}
