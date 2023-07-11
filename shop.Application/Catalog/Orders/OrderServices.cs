using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Orders;

public class OrderServices : BaseServices, IOrderServices
{
    public OrderServices(ShopDbContext context) : base(context)
    {
    }

    public async Task<PagedResult<OrderVm>> GetOrdersPaging(OrderPagingRequest request)
    {
        var query = _context.Orders
                             .Include(o => o.User)
                             .OrderBy(o => o.CreatedDate)
                             .AsQueryable();

        if (!string.IsNullOrEmpty(request.KeyWord))
        {
            var keyword = request.KeyWord.ToLower(); // Convert the keyword to lowercase

            query = query.Where(o =>
                o.OrderCode.ToLower().Contains(keyword) ||
                o.User.FirstName.ToLower().Contains(keyword) ||
                o.User.LastName.ToLower().Contains(keyword)
            );
        }

        if (request.Status != OrderStatus.None)
        {
            query = query.Where(o => o.OrderStatus == request.Status);
        }

        int totalRow = await query.CountAsync();

        var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(o => new OrderVm
            {
                Id = o.Id,
                CustomerId = (Guid)o.UserId,
                OrderCode = o.OrderCode,
                CustomerName = $"{o.User.FirstName} {o.User.LastName}",
                Total = o.Total,
                Status = o.OrderStatus
            })
            .ToListAsync();

        var pagedResult = new PagedResult<OrderVm>()
        {
            TotalRecords = totalRow,
            PageSize = request.PageSize,
            PageIndex = request.PageIndex,
            Items = data
        };

        return pagedResult;
    }

    public async Task<List<OrderDetailVm>> GetOrderDetails(Guid id)
    {
        var data = await _context.Orders
            .Include(o => o.OrderDetails)
                .ThenInclude(od => od.ProductDetail)
                    .ThenInclude(pd => pd.Product)
            .Join(
                _context.Users,
                o => o.UserId,
                u => u.Id,
                (o, u) => new { Order = o, User = u }
            )
            .Where(o => o.Order.Id == id)
            .Select(o => new OrderDetailVm
            {
                OrderId = o.Order.Id,
                ProductDetailId = o.Order.User.Id,
                ProductName = o.Order.OrderDetails.Select(od => od.ProductDetail.Product.Name).FirstOrDefault(),
                Price = o.Order.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                Quantity = o.Order.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                SubTotal = o.Order.OrderDetails.Select(od => od.Price * od.Quantity).FirstOrDefault(),
                CustomerName = $"{o.User.FirstName} {o.User.LastName}",
                OrderCode = o.Order.OrderCode
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

        return new ApiSuccessResult<bool>($"Xác nhận thành công đơn hàng: {existingOrder.OrderCode}");
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

        return new ApiSuccessResult<bool>($"Đã gửi đơn hàng {existingOrder.OrderCode} tới đơn vị vận chuyển");
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

        return new ApiSuccessResult<bool>($"Đã hoàn thành đơn hàng {existingOrder.OrderCode}");
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

        return new ApiSuccessResult<bool>($"Đã hủy đơn hàng {existingOrder.OrderCode}");
    }
}
