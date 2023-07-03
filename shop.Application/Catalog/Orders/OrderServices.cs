using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Enums;
using shop.Utilities.Exceptions;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;
using System.Reflection.Metadata.Ecma335;

namespace shop.Application.Catalog.Orders
{
    public class OrderServices : IOrderServices
    {
        private readonly ShopDbContext _context;

        public OrderServices(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderVm>> GetAll()
        {
            var query = from o in _context.Orders
                        join c in _context.Users on o.UserId equals c.Id
                        select new { o, c };

            var data = await query.Select(x => new OrderVm
            {
                Id = x.o.Id,
                CustomerId = x.c.Id,
                OrderCode = x.o.OrderCode,
                CustomerName = x.c.LastName + " " + x.c.FirstName,
                Total = x.o.Total,
                Status = x.o.OrderStatus
            }).ToListAsync();

            return data;
        }

        public async Task<List<OrderVm>> GetOrderByStatus(OrderStatus status)
        {
            var data = await GetAll();
            var list = data.Where(x => x.Status == status).ToList();
            return list;
        }

        public async Task<List<OrderDetailVm>> GetOrderDetails(Guid id)
        {
            var query = from o in _context.Orders
                        join od in _context.OrderDetails on o.Id equals od.OrderId
                        join c in _context.AppUsers on o.UserId equals c.Id
                        join pd in _context.ProductDetails on od.ProductDetailId equals pd.Id
                        join p in _context.Products on pd.ProductId equals p.Id
                        where od.OrderId == id
                        select new { od, c, o, pd, p };

            var data = await query.Select(x => new OrderDetailVm
            {
                OrderId = x.o.Id,
                ProductDetailId = x.c.Id,
                ProductName = x.p.Name,
                Price = x.od.Price,
                Quantity = x.od.Quantity,
                SubTotal = x.od.Price * x.od.Quantity
            }).ToListAsync();

            return data;
        }

        public async Task<ApiResult<bool>> ConfirmOrder(Guid id)
        {
            var existingOrder = await _context.Orders.FindAsync(id);
            if (existingOrder == null)
            {
                return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
            }
            if (existingOrder.OrderStatus != OrderStatus.Pending) throw new ShopException("Đơn hàng này có trạng thái khác trạng thái 'chờ'");

            existingOrder.OrderStatus = OrderStatus.Confirmed;
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

            existingOrder.OrderStatus = OrderStatus.Canceled;
            foreach (var item in _context.OrderDetails.Where(x => x.OrderId == id))
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
