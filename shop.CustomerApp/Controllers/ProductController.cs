using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Products;
using shop.Application.Catalog.Products;
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
        public async Task<IActionResult> ShowAllProduct()
        {
            var data = await _productApiClient.GetListProductProp();
            return View(data);
            
        }
    }
}
