using shop.Data.Entities;
using shop.ViewModels.Catalog.Carts;

namespace shop.Application.Catalog.Carts;

public interface ICartServices
{
    Task<List<Cart>> GetAll();
    Task<bool> Create(CartActionRequest request);
    Task<bool> Update(CartActionRequest request);
    Task<bool> Delete(CartActionRequest request);
    Task<ShowCartResult> ShowCart(Guid id);
    Task<bool> AddToCart(Guid userId, Guid productId, Guid sizeId, int quantity);
    Task<CheckOutVm> CheckOut(Guid userId);
    Task<bool> PlaceOrder(Guid userId, string shipName, string shipPhoneNumber, string shipAddress);
}
