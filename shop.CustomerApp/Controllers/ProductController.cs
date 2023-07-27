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
        
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> ShowAllProduct(string? keyword, int pageindex = 1, int pagesize =10)
        {
            var resquest = new ProductPagingRequest()
            {
                PageIndex = pageindex,

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
