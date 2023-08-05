using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Entities;
using shop.ViewModels.Catalog.Carts;

namespace shop.Application.Catalog.Carts
{
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
    }
}
