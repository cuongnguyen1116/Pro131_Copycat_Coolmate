using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Products;
using shop.CustomerApp.Models;
using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Show(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 9)
        {

            var request = new ProductPagingRequest()
            {
                Keyword = keyword,
                CategoryId = categoryId,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _productApiClient.GetAllProduct(request);
            //var viewmodel = new ProductDetailViewModel()
            //{
            //    Products = data
            //};
            ViewBag.Keyword = keyword;
            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.ToString() == x.Id.ToString()
            });
            return View(data);
        }

        public async Task<IActionResult> Detail(Guid id)
        {

            return View();
        }
    }
}
