using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Orders
{
    public class OrderServices : BaseServices, IOrderServices
    {
        public OrderServices(ShopDbContext context) : base(context)
        {
        }

        public async Task<List<OrderVm>> GetAll()
        {
            var data = await _context.Orders
                .Include(o => o.User)
                .OrderBy(o => o.OrderStatus)
                .Select(o => new OrderVm
                {
                    Id = o.Id,
                    CustomerId = (Guid)o.UserId,
                    OrderCode = o.OrderCode,
                    CustomerName = $"{o.User.LastName} {o.User.FirstName}",
                    Total = o.Total,
                    Status = o.OrderStatus
                })
                .ToListAsync();

            return data;
        }

        public async Task<List<OrderVm>> GetOrdersByStatus(OrderStatus status)
        {
            var data = await GetAll();
            var list = data.Where(x => x.Status == status).ToList();
            return list;
        }

        public async Task<List<OrderDetailVm>> GetOrderDetails(Guid id)
        {
            var data = await _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.ProductDetail)
                        .ThenInclude(pd => pd.Product)
                .Where(o => o.Id == id)
                .Select(o => new OrderDetailVm
                {
                    OrderId = o.Id,
                    ProductDetailId = o.User.Id,
                    ProductName = o.OrderDetails.Select(od => od.ProductDetail.Product.Name).FirstOrDefault(),
                    Price = o.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                    Quantity = o.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                    SubTotal = o.OrderDetails.Select(od => od.Price * od.Quantity).FirstOrDefault()
                })
                .ToListAsync();

            return data;
        }

        public async Task<ApiResult<bool>> ConfirmOrder(Guid id)
        {
            var existingOrder = await _context.Orders.FindAsync(id);
            if (existingOrder == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
            }
            if (existingOrder.OrderStatus != OrderStatus.Pending)
            {
                return new ApiErrorResult<bool>("Đơn hàng này có trạng thái khác trạng thái 'chờ'");
            }

            existingOrder.ConfirmedDate = DateTime.Now;
            existingOrder.OrderStatus = OrderStatus.AwaitingShipment;
            _context.Orders.Update(existingOrder);
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> GetOrderToShipper(Guid id)
        {
            var existingOrder = await _context.Orders.FindAsync(id);
            if (existingOrder == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
            }

            existingOrder.OrderStatus = OrderStatus.AWaitingPickup;
            _context.Orders.Update(existingOrder);
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> CompleteOrder(Guid id)
        {
            var existingOrder = await _context.Orders.FindAsync(id);
            if (existingOrder == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
            }

            existingOrder.CompletedDate = DateTime.Now;
            existingOrder.OrderStatus = OrderStatus.Completed;
            _context.Orders.Update(existingOrder);
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> CancelOrder(Guid id)
        {
            var existingOrder = await _context.Orders.FindAsync(id);
            if (existingOrder == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
            }

            existingOrder.OrderStatus = OrderStatus.Cancelled;
            var existingorderDetails = _context.OrderDetails.Where(x => x.OrderId == id);

            foreach (var item in existingorderDetails)
            {
                item.Status = Status.Inactive;
                _context.OrderDetails.Update(item);
            }

            _context.Orders.Update(existingOrder);
            await _context.SaveChangesAsync();

            return new ApiSuccessResult<bool>();
        }

    }
}
