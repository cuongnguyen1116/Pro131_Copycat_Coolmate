using shop.ViewModels.Catalog.Carts;
using shop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Carts
{
    public interface ICartApiClient
    {
        Task<ShowCartResult> ShowCart(Guid id);
        Task<bool> AddToCart(Guid userId, Guid productId, Guid sizeId, int quantity);
        Task<CheckOutVm> CheckOut(Guid userId);
        Task<bool> PlaceOrder(Guid userId,string shipName,string shipPhoneNumber,string shipAddress);
    }
}
