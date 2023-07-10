using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Sizes;

namespace shop.AdminApp.Controllers
{
    public class SizesController : Controller
    {
        readonly ISizesApiClient _sizeApiClient;
        public SizesController(ISizesApiClient sizeApiClient)
        {
            _sizeApiClient = sizeApiClient;
        }
        public async Task<IActionResult> Show()
        {
            var data = await _sizeApiClient.GetAll();
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        public async Task<IActionResult> GetById(Guid id)
        {
            var data = await _sizeApiClient.GetById(id);
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

    }
}
