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
        #region năm tháng ngu muội
        //var query = _context.Orders
        //    .Include(o => o.OrderDetails)
        //        .ThenInclude(od => od.ProductDetail)
        //            .ThenInclude(pd => pd.Product)
        //    .Join(
        //        _context.Users,
        //        o => o.UserId,
        //        u => u.Id,
        //        (o, u) => new { Order = o, User = u }
        //    )
        //    .Where(o => o.Order.Id == id)
        //    .Select(o => new OrderDetailVm
        //    {
        //        OrderId = o.Order.Id,
        //        ProductDetailId = o.Order.OrderDetails.Select(od => od.ProductDetail.Id).FirstOrDefault(),
        //        ProductName = o.Order.OrderDetails.Select(od => od.ProductDetail.Product.Name).FirstOrDefault(),
        //        Price = o.Order.OrderDetails.Select(od => od.Price).FirstOrDefault(),
        //        Quantity = o.Order.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
        //        SubTotal = o.Order.OrderDetails.Select(od => od.Price * od.Quantity).FirstOrDefault(),
        //        CustomerName = $"{o.User.FirstName} {o.User.LastName}",
        //        OrderCode = o.Order.OrderCode
        //    });
        #endregion

        var query = from o in _context.Orders
                    join od in _context.OrderDetails on o.Id equals od.OrderId
                    join pd in _context.ProductDetails on od.ProductDetailId equals pd.Id
                    join p in _context.Products on pd.ProductId equals p.Id
                    where od.OrderId == id
                    select new OrderDetailVm
                    {
                        ProductName = p.Name,
                        Quantity = od.Quantity,
                        Price = od.Price,
                        SubTotal = od.Quantity * od.Price
                    };

        var data = await query.ToListAsync();

        return data;
    }

    // xác nhận cho tất cả các đơn hàng có trạng thái là pending (chờ)
    public async Task<ApiResult<bool>> ConfirmAllOrder()
    {
        var listPendingOrders = _context.Orders.Where(x => x.OrderStatus == OrderStatus.Pending).ToList();
        foreach (var order in listPendingOrders)
        {
            order.CompletedDate = DateTime.Now;
            order.OrderStatus = OrderStatus.AwaitingShipment;
            _context.Orders.Update(order);
        }
        await _context.SaveChangesAsync();

        return new ApiSuccessResult<bool>("Xác nhận thành công tất cả các đơn hàng chờ xác nhận");
    }

    public async Task<ApiResult<bool>> ConfirmOrder(Guid id)
    {
        // Tìm hóa đơn theo id
        var existingOrder = await _context.Orders.FindAsync(id);
        if (existingOrder == null)
        {
            return new ApiErrorResult<bool>($"Không tìm thấy đơn hàng có id {id}");
        }
        if (existingOrder.OrderStatus != OrderStatus.Pending)
        {
            return new ApiErrorResult<bool>("Đơn hàng này có trạng thái khác trạng thái 'chờ'");
        }
        // Sử dụng transaction để đảm bảo tính toàn vẹn dữ liệu khi cập nhật số lượng sản phẩm và trạng thái đơn hàng
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            // Lấy list hóa đơn chi tiết của đơn hàng này
            var listOrderDetails = await _context.OrderDetails.Where(x => x.OrderId == id).ToListAsync();
            // Kiểm tra số lượng tồn của sản phẩm và xử lý việc trừ số lượng 
            foreach (var orderDetail in listOrderDetails)
            {
                var productDetail = await _context.ProductDetails.FirstOrDefaultAsync(x => x.Id == orderDetail.ProductDetailId);
                if (productDetail.Stock >= orderDetail.Quantity)
                {
                    productDetail.Stock -= orderDetail.Quantity;
                    _context.ProductDetails.Update(productDetail);
                }
                else
                {
                    transaction.Rollback(); // Rollback transaction nếu số lượng mua vượt quá số lượng tồn của sản phẩm
                    var product = await _context.Products.FindAsync(productDetail.ProductId);
                    return new ApiErrorResult<bool>($"Số lượng mua cho {product.Name} vượt quá số lượng tồn của sản phẩm. Vui lòng giảm số lượng hoặc đổi sang 1 sản phẩm khác.");
                }
            }
            // Cập nhật trạng thái và ngày xác nhận đơn hàng
            existingOrder.ConfirmedDate = DateTime.Now;
            existingOrder.OrderStatus = OrderStatus.AwaitingShipment;
            _context.Orders.Update(existingOrder);
            // Lưu thay đổi vào database
            await _context.SaveChangesAsync();
            transaction.Commit(); // Commit transaction nếu mọi thứ đều thành công
            return new ApiSuccessResult<bool>($"Xác nhận thành công đơn hàng: {existingOrder.OrderCode}");
        }
        catch (Exception)
        {
            transaction.Rollback(); // Rollback transaction nếu xảy ra lỗi
            return new ApiErrorResult<bool>("Đã xảy ra lỗi trong quá trình xác nhận đơn hàng.");
        }
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
