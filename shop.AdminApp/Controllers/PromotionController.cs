using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Promotions;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Promotions;

namespace shop.AdminApp.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IPromotionApiClient _promotionApiClient;
        public PromotionController(IPromotionApiClient promotionApiClient)
        {
            _promotionApiClient = promotionApiClient;
        }
        // GET: PromotionController
        public async Task<IActionResult> Show(string? keyword, PromotionStatus status, string? PromotionCode, int pageIndex = 1, int pageSize = 10)
        {
            var request = new PromotionPagingRequest()
            {
                KeyWord = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Status = status,
                PromotionCode = PromotionCode
            };
            var data = await _promotionApiClient.GetAll(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var promotion = await _promotionApiClient.GetById(id);
            // Lưu giá trị thuộc tính vào TempData để tái sử dụng ở trang tạo mới

            TempData["DiscountPercent"] = promotion.DiscountPercent;
            TempData["DiscountAmount"] = promotion.DiscountAmount;

            return View(promotion);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.DiscountPercent = TempData["DiscountPercent"];
            ViewBag.DiscountAmount = TempData["DiscountAmount"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PromotionCreateRequest collection)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            ViewBag.DiscountPercent = TempData["DiscountPercent"];
            ViewBag.DiscountAmount = TempData["DiscountAmount"];
            var result = await _promotionApiClient.CreatePromotion(collection);
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
            var promotion = await _promotionApiClient.GetById(id);
            var editvm = new PromotionUpdateRequest()
            {
                Id = promotion.Id,
                StartDate = promotion.StartDate,
                FinishDate = promotion.FinishDate,
                DiscountPercent = promotion.DiscountPercent,
                DiscountAmount = promotion.DiscountAmount,
                Status = promotion.Status,
            };

            return View(editvm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PromotionUpdateRequest collection)
        {
            if (!ModelState.IsValid)
                return View(collection);

            var result = await _promotionApiClient.UpdatePromotion(collection);
            if (result)
            {
                TempData["result"] = "Cập nhật thành công";
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Cập nhật thất bại");
            return View(collection);
        }

    }
}
