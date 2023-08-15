using Microsoft.EntityFrameworkCore;
using shop.Application.Common.Utilities;
using shop.Data.Context;
using shop.Data.Entities;
using shop.ViewModels.Catalog.Carts;

namespace shop.Application.Catalog.Carts;

public class CartServices : BaseServices, ICartServices
{
    public CartServices(ShopDbContext context) : base(context)
    {

    }

    public async Task<List<Cart>> GetAll()
    {
        var listCart = await _context.Carts.ToListAsync();
        return listCart;
    }

    public async Task<bool> Create(CartActionRequest request)
    {
        var existingCart = await _context.Carts.FindAsync(request.UserId);
        if (existingCart == null)
        {
            var cart = new Cart
            {
                UserId = request.UserId,
                Description = request.Description
            };
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<bool> Update(CartActionRequest request)
    {
        var existingCart = await _context.Carts.FindAsync(request.UserId);
        if (existingCart != null)
        {
            existingCart.Description = request.Description;
            _context.Carts.Update(existingCart);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<bool> Delete(CartActionRequest request)
    {
        var existingCart = await _context.Carts.FindAsync(request.UserId);
        if (existingCart != null)
        {
            _context.Carts.Remove(existingCart);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<ShowCartResult> ShowCart(Guid id)
    {
        var query = from c in _context.Carts
                    join cd in _context.CartDetails on c.UserId equals cd.UserId
                    join pd in _context.ProductDetails on cd.ProductDetailId equals pd.Id
                    join p in _context.Products on pd.ProductId equals p.Id
                    join pi in _context.ProductImages on p.Id equals pi.ProductId
                    join s in _context.Sizes on pd.SizeId equals s.Id
                    join col in _context.Colors on pd.ColorId equals col.Id
                    where c.UserId == id && pi.IsDefault == true
                    select new CartDetailVm
                    {
                        Id = cd.Id,
                        ProductName = p.Name,
                        ImagePath = pi.ImagePath,
                        SizeName = s.Name,
                        ColorName = col.Name,
                        Quantity = cd.Quantity,
                        Price = cd.Price,
                        SubTotal = cd.Quantity * cd.Price
                    };

        var cartDetailVms = await query.ToListAsync();
        decimal grandTotal = cartDetailVms.Sum(item => item.SubTotal);

        var result = new ShowCartResult
        {
            Id = id,
            ListCartDetail = cartDetailVms,
            GrandTotal = grandTotal
        };

        return result;
    }

    public async Task<bool> AddToCart(Guid userId, Guid productId, Guid sizeId, int quantity)
    {
        var productDetail = await _context.ProductDetails.FirstOrDefaultAsync(x => x.ProductId == productId && x.SizeId == sizeId);

        if (productDetail == null)
        {
            return false; // ProductDetail không tồn tại
        }
        else
        {
            var existingCartDetail = await _context.CartDetails.FirstOrDefaultAsync(x => x.UserId == userId && x.ProductDetailId == productDetail.Id);

            if (existingCartDetail != null)
            {
                // Nếu đã có trong CartDetail, cập nhật số lượng
                existingCartDetail.Quantity += quantity;
            }
            else
            {
                // Nếu chưa có trong CartDetail, thêm mới
                CartDetail cartDetail = new()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    ProductDetailId = productDetail.Id,
                    Price = productDetail.Price,
                    Quantity = quantity
                };
                await _context.CartDetails.AddAsync(cartDetail);
            }

            await _context.SaveChangesAsync();
            return true;
        }
    }

    public async Task<CheckOutVm> CheckOut(Guid userId)
    {
        var user = await _context.AppUsers.FindAsync(userId);
        if (user == null)
        {
            return null;
        }
        else
        {
            var cart = await ShowCart(userId);
            var checkoutvm = new CheckOutVm
            {
                UserId = userId,
                UserName = user.FirstName + " " + user.LastName,
                PhoneNumber = user.PhoneNumber,
                GrandTotal = cart.GrandTotal,
                ProductCount = cart.ListCartDetail.Count,
            };
            return checkoutvm;
        }
    }

    public async Task<bool> PlaceOrder(Guid userId, string shipName, string shipPhoneNumber, string shipAddress)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();

        var user = await _context.AppUsers.FindAsync(userId);
        if (user == null)
        {
            return false;
        }

        var cart = await ShowCart(userId);

        var order = new Order
        {
            Id = Guid.NewGuid(),
            OrderCode = UtilityServices.RandomString(16),
            UserId = userId,
            CreatedDate = DateTime.Now,
            ShipName = shipName,
            ShipAddress = shipAddress,
            ShipPhoneNumber = shipPhoneNumber,
            Total = cart.GrandTotal
        };

        await _context.Orders.AddAsync(order);

        var listCartDetails = await _context.CartDetails.Where(x => x.UserId == userId).ToListAsync();
        var orderDetails = listCartDetails.Select(item => new OrderDetail
        {
            Id = Guid.NewGuid(),
            OrderId = order.Id,
            ProductDetailId = item.ProductDetailId,
            Price = item.Price,
            Quantity = item.Quantity,
            Status = 0,
        }).ToList();

        _context.OrderDetails.AddRange(orderDetails);
        _context.CartDetails.RemoveRange(listCartDetails);

        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return true;
    }

}
