using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Orders
{
    public interface IOrderServices
    {
        Task<List<OrderVm>> GetAll();
        Task<List<OrderVm>> GetOrdersByStatus(OrderStatus status);
        Task<List<OrderDetailVm>> GetOrderDetails(Guid id);
        Task<ApiResult<bool>> ConfirmOrder(Guid id);
        Task<ApiResult<bool>> CancelOrder(Guid id);
        Task<ApiResult<bool>> CompleteOrder(Guid id);
    }
}
