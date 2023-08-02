using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shop.CustomerApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }

    }
}
