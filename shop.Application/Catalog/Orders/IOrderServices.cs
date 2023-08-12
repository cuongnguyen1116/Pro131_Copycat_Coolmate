using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Orders;

public interface IOrderServices
{
    Task<PagedResult<OrderVm>> GetOrdersPaging(OrderPagingRequest request);
    Task<List<OrderDetailVm>> GetOrderDetails(Guid id);
    Task<ApiResult<bool>> ConfirmAllOrder();
    Task<ApiResult<bool>> ConfirmOrder(Guid id);
    Task<ApiResult<bool>> GetOrderToShipper(Guid id);
    Task<ApiResult<bool>> CompleteOrder(Guid id);
    Task<ApiResult<bool>> CancelOrder(Guid id);
    Task<PagedResult<OrderVm>> GetAllByIdUser(Guid id, int PageIndex, int PageSize);
}
