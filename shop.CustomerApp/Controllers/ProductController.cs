using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Products;
using shop.ViewModels.Catalog.Products;

namespace shop.CustomerApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> ShowAllProduct(int index, int pagesize, string keyword)
        {
            var resquest = new ProductPagingRequest()
            {
                PageIndex = index,
                PageSize = pagesize,
                Keyword = keyword
            };
            var data = await _productApiClient.GetAll(resquest);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> ShowProductDetail(Guid id)
        {
            var data = await _productApiClient.GetByIdProductProp(id);
            return View(data);
        }
    }
}
