using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Products;
using shop.ViewModels.Catalog.Categories;
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
        [HttpGet("propductprops")]
        public async Task<IActionResult> GetAllProductProp()
        {
            var result = await _productServices.GetAllProductProp();
            return Ok(result);
        }
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
        [HttpDelete("delete/{productDetailId}")]
        public async Task<IActionResult> Delete(Guid productDetailId)
        {
            var check = await _productServices.Delete(productDetailId);
            if (check == null)
                return BadRequest();
            return Ok();
        }
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
        [HttpDelete("deleteProductProp/{productPropId}")]
        public async Task<IActionResult> DeleteProductProp(Guid productPropId)
        {
            var check = await _productServices.DeleteProductProp(productPropId);
            if (check == null)
                return BadRequest();
            return Ok();
        }
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
