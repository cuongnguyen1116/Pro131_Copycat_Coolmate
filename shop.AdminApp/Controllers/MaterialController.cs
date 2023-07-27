using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Materials;
using shop.ViewModels.Catalog.Materials;
using shop.ViewModels.Catalog.Products;

namespace shop.AdminApp.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialApiClient _materialApiClient;
        public MaterialController(IMaterialApiClient materialApiClient)
        {
            _materialApiClient = materialApiClient;
        }
        public async Task<IActionResult> Show()
        {
            var data = await _materialApiClient.GetAll();
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
        public async Task<IActionResult> Create(MaterialCreateRequest collection)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var result = await _materialApiClient.CreateMaterial(collection);
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
            var material = await _materialApiClient.GetById(id);
            var editvm = new MaterialUpdateRequest()
            {
                Id = material.Id,
                Name = material.Name,
            };

            return View(editvm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MaterialUpdateRequest collection)
        {
            if (!ModelState.IsValid)
                return View(collection);

            var result = await _materialApiClient.UpdateMaterial(collection);
            if (result)
            {
                TempData["result"] = "Cập nhật thành công";
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Cập nhật thất bại");
            return View(collection);
        }
        public async Task<IActionResult> Delete(MaterialDeleteRequest collection)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _materialApiClient.DeleteMaterial(collection);
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
