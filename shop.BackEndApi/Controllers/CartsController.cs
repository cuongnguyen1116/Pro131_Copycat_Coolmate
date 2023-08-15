using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Carts;
using shop.ViewModels.Catalog.Carts;

namespace shop.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartServices _cartServices;

        public CartsController(ICartServices cartServices)
        {
            _cartServices = cartServices;
        }

        [HttpGet("ShowCart")]
        public async Task<ShowCartResult> ShowDetail([FromQuery] Guid id)
        {
            return await _cartServices.ShowCart(id);
        }

        [HttpGet("AddToCart")]
        public async Task<bool> AddToCart(Guid userId, Guid productId, Guid sizeId, int quantity)
        {
            return await _cartServices.AddToCart(userId, productId, sizeId, quantity);
        }

        [HttpGet("CheckOut")]
        public async Task<CheckOutVm> CheckOut(Guid userId)
        {
            return await _cartServices.CheckOut(userId);
        }

        [HttpGet("PlaceOrder")]
        public async Task<bool> PlaceOrder(Guid userId, string shipName, string shipPhoneNumber, string shipAddress)
        {
            return await _cartServices.PlaceOrder(userId, shipName, shipPhoneNumber, shipAddress);
        }
    }
}
