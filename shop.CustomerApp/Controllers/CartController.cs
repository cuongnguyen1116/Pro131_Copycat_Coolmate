using Microsoft.AspNetCore.Mvc;

namespace shop.CustomerApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ShowCart()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }   
            return View();
        }
    }
}
