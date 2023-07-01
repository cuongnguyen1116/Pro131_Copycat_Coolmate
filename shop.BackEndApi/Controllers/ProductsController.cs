using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Product;
using shop.ViewModels.Catalog.Products;

namespace shop.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productServices.GetAll();
            return Ok(result);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sanphamId = await _productServices.Create(request);
            if (sanphamId == null)
                return BadRequest();
            else
            {
                HttpContext.Response.StatusCode = 201;
                return Ok(request);
            }
        }
        [HttpPut("{productDetailId}")]
        [Consumes("multipart/form-data")]
        
        public async Task<IActionResult> Update([FromRoute] Guid productDetailId, [FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productDetailId;
            var affectedResult = await _productServices.Update(request);
            if (affectedResult == null)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{productDetailId}")]
        public async Task<IActionResult> Delete(Guid productDetailId)
        {
            var affectedResult = await _productServices.Delete(productDetailId);
            if (affectedResult == null)
                return BadRequest();
            return Ok();
        }
        [HttpGet("{productDetailId}")]
        public async Task<IActionResult> GetById(Guid productDetailId)
        {
            var product = await _productServices.GetById(productDetailId);
            if (product == null)
            {
                return BadRequest("Can't find product");
            }
            return Ok(product);
        }
    }
}
