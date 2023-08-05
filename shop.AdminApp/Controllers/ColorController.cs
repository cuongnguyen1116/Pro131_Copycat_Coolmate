using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Colors;
using shop.ViewModels.Catalog.Colors;

namespace shop.AdminApp.Controllers
{
    [Authorize(Policy = "admin")]
    public class ColorController : Controller
    {
        private readonly IColorApiClient _ColorApiClient;
        public ColorController(IColorApiClient ColorApiClient)
        {
            _ColorApiClient = ColorApiClient;
        }
        public async Task<IActionResult> Show()
        {
            var data = await _ColorApiClient.GetAll();
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ColorCreateRequest collection)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var result = await _ColorApiClient.CreateColor(collection);
            if (result)
            {
                TempData["result"] = "Thêm mới thành công";
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Thêm mới thất bại");
            return View(collection);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var color = await _ColorApiClient.GetById(id);
            var editvm = new ColorUpdateRequest()
            {
                Id = color.Id,
                Name = color.Name,
            };

            return View(editvm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ColorUpdateRequest collection)
        {
            if (!ModelState.IsValid)
                return View(collection);

            var result = await _ColorApiClient.UpdateColor(collection);
            if (result)
            {
                TempData["result"] = "Cập nhật thành công";
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Cập nhật thất bại");
            return View(collection);
        }
        public async Task<IActionResult> Delete(ColorDeleteRequest collection)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _ColorApiClient.DeleteColor(collection);
            if (result)
            {
                TempData["result"] = "Xóa thành công";
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(collection);
        }
    }
}
