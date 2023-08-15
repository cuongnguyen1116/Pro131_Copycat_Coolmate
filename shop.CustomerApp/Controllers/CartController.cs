using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Carts;

namespace shop.CustomerApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartApiClient _cartApiClient;

        public CartController(ICartApiClient cartApiClient)
        {
            _cartApiClient = cartApiClient;
        }

        public async Task<IActionResult> ShowCart()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var id = HttpContext.Session.GetString("userId");
                Guid userId = Guid.Parse(id);
                var data = await _cartApiClient.ShowCart(userId);
                return View(data);
            }
        }

        public async Task<IActionResult> AddToCart(Guid productId, Guid sizeId, int quantity)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var id = HttpContext.Session.GetString("userId");
                Guid userId = Guid.Parse(id);
                var data = await _cartApiClient.AddToCart(userId, productId, sizeId, quantity);
                if (data)
                {
                    return RedirectToAction("ShowCart");
                }
                else
                {
                    return View();
                }
            }
        }

        public async Task<IActionResult> CheckOut()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var id = HttpContext.Session.GetString("userId");
                Guid userId = Guid.Parse(id);
                var data = await _cartApiClient.CheckOut(userId);
                if (data != null)
                {
                    return View(data);
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(string shipName, string shipPhoneNumber, string shipAddress)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var id = HttpContext.Session.GetString("userId");
                Guid userId = Guid.Parse(id);
                var data = await _cartApiClient.PlaceOrder(userId, shipName, shipPhoneNumber, shipAddress);
                if (data != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}
