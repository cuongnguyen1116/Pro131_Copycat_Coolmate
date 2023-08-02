using Microsoft.AspNetCore.Mvc;

namespace shop.CustomerApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
