using shop.Data.Entities;
using shop.ViewModels.Catalog.Carts;

namespace shop.Application.Catalog.Carts;

public interface ICartServices
{
    Task<List<Cart>> GetAll();
    Task<bool> Create(CartActionRequest request);
    Task<bool> Update(CartActionRequest request);
    Task<bool> Delete(CartActionRequest request);
}
