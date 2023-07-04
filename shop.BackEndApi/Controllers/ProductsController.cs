using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Products;
using shop.Data.Entities;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

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
        // Bảng ProductDetail
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ProductPropRequest request)
        {
            var result = await _productServices.GetAll(request);
            return Ok(result);
        }
        //Bảng product
        [HttpGet("propductprops")]/*?name={request.Keyword}&categoryId={request.CategoryId}*/
        public async Task<IActionResult> GetAllProductProp([FromQuery]ProductPropRequest request)
        {
            var result = await _productServices.GetAllProductProp(request);
            return Ok(result);
        }
        [HttpGet("listPropductProp")]
        public async Task<IActionResult> GetListProductProp()
        {
            var result = await _productServices.GetListProductProp();
            return Ok(result);
        }
        // Bảng ProductDetail
        [HttpPost("create")]
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
        // Bảng ProductDetail
        [HttpPut("update/{productDetailId}")]
        [Consumes("multipart/form-data")]

        public async Task<IActionResult> Update([FromRoute] Guid productDetailId, [FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productDetailId;
            var check = await _productServices.Update(request);
            if (check == null)
                return BadRequest();
            return Ok();
        }
        // Bảng ProductDetail
        [HttpDelete("delete/{productDetailId}")]
        public async Task<IActionResult> Delete(Guid productDetailId)
        {
            var check = await _productServices.Delete(productDetailId);
            if (check == null)
                return BadRequest();
            return Ok();
        }
        // Bảng ProductDetail
        [HttpGet("product/{productDetailId}")]
        public async Task<IActionResult> GetById(Guid productDetailId)
        {
            var product = await _productServices.GetById(productDetailId);
            if (product == null)
            {
                return BadRequest("Can't find product");
            }
            return Ok(product);
        }
        //Bang Product
        [HttpPost("createproductprop")]
        public async Task<IActionResult> CreateProductProp([FromBody] ProductPropVm request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sanphamId = await _productServices.CreateProductProp(request);
            if (sanphamId == null)
                return BadRequest();
            else
            {
                HttpContext.Response.StatusCode = 201;
                return Ok(request);
            }
        }
        //Bang Product
        [HttpPut("updateProductProp/{productPropId}")]
        public async Task<IActionResult> UpdateProductProp([FromRoute] Guid productPropId, ProductPropVm request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productPropId;
            var check = await _productServices.UpdateProductProp(request);
            if (check == null)
                return BadRequest();
            return Ok();
        }
        //Bang Product
        [HttpDelete("deleteProductProp/{productPropId}")]
        public async Task<IActionResult> DeleteProductProp(Guid productPropId)
        {
            var check = await _productServices.DeleteProductProp(productPropId);
            if (check == null)
                return BadRequest();
            return Ok();
        }
        //Bang Product
        [HttpGet("productprop/{productPropId}")]
        public async Task<IActionResult> GetByIdProductProp(Guid productPropId)
        {
            var product = await _productServices.GetByIdProductProp(productPropId);
            if (product == null)
            {
                return BadRequest("Can't find product");
            }
            return Ok(product);
        }
        [HttpPut("productProp/{id}/categories")]
        public async Task<IActionResult> CategoryAssign(Guid id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productServices.CategoryAssign(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
