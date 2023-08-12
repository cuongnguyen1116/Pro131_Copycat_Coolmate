using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Products;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;

namespace shop.BackEndApi.Controllers;

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
    [HttpGet("productdetails")]
    public async Task<IActionResult> GetAllProductDetail([FromQuery] ProductPagingRequest request)
    {
        var result = await _productServices.GetAllProductDetail(request);
        return Ok(result);
    }

    //Bảng product
    [HttpGet("products")]/*?keyword={request.Keyword}&categoryId={request.CategoryId}*/
    public async Task<IActionResult> GetAllProduct([FromQuery] ProductPagingRequest request)
    {
        var result = await _productServices.GetAllProduct(request);
        return Ok(result);
    }

    [HttpGet("listPropduct")]
    public async Task<IActionResult> GetListProduct()
    {
        var result = await _productServices.GetListProduct();
        return Ok(result);
    }

    // Bảng ProductDetail
    [HttpPost("create-productdetail")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateProductDetail([FromForm] ProductDetailCreateRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var sanphamId = await _productServices.CreateProductDetail(request);
        if (sanphamId == false)
            return BadRequest();
        else
        {
            HttpContext.Response.StatusCode = 201;
            return Ok(request);
        }
    }

    // Bảng ProductDetail
    [HttpPut("update-productdetail/{productDetailId}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateProductDetail([FromRoute] Guid productDetailId, [FromForm] ProductDetailUpdateRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        request.Id = productDetailId;
        var check = await _productServices.UpdateProductDetail(request);
        if (check == false)
            return BadRequest();
        return Ok();
    }

    // Bảng ProductDetail
    [HttpDelete("delete-productdetail/{productDetailId}")]
    public async Task<IActionResult> DeleteProductDetail(Guid productDetailId)
    {
        var check = await _productServices.DeleteProductDetail(productDetailId);
        if (check == false)
            return BadRequest();
        return Ok();
    }

    // Bảng ProductDetail
    [HttpGet("productdetail/{productDetailId}")]
    public async Task<IActionResult> GetByIdProductDetail(Guid productDetailId)
    {
        var product = await _productServices.GetByIdProductDetail(productDetailId);
        if (product == null)
        {
            return BadRequest("Can't find product");
        }
        return Ok(product);
    }

    //Bang Product
    [HttpPost("createproduct")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateProduct([FromForm] ProductRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var sanphamId = await _productServices.CreateProduct(request);
        if (sanphamId == false)
            return BadRequest();
        else
        {
            HttpContext.Response.StatusCode = 201;
            return Ok(request);
        }
    }

    //Bang Product
    [HttpPut("updateProduct/{productId}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateProduct([FromRoute] Guid productId, [FromForm] ProductRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        request.Id = productId;
        var check = await _productServices.UpdateProduct(request);
        if (check == false)
            return BadRequest();
        return Ok();
    }

    //Bang Product
    [HttpDelete("deleteProduct/{productId}")]
    public async Task<IActionResult> DeleteProduct(Guid productId)
    {
        var check = await _productServices.DeleteProduct(productId);
        if (check == false)
            return BadRequest();
        return Ok();
    }

    //Bang Product
    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByIdProduct(Guid productId)
    {
        var product = await _productServices.GetByIdProduct(productId);
        if (product == null)
        {
            return BadRequest("Can't find product");
        }
        return Ok(product);
    }

    [HttpPut("product/{id}/categories")]
    public async Task<IActionResult> CategoryAssign(Guid id, [FromBody] CategoryAssignRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _productServices.CategoryAssign(id, request);
        if (result.IsSuccessed)
            return Ok(result);

        return BadRequest(result);
    }

    [HttpPost("create-image")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateImage([FromForm] ProductImageRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var productImage = await _productServices.AddImages(request);
        if (productImage.IsSuccessed)
            return Ok(productImage);
        return BadRequest();

    }

    [HttpGet("featured/{take}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetFeaturedProducts(int take)
    {
        var products = await _productServices.GetFeaturedProducts(take);
        return Ok(products);
    }

    [HttpGet("recent/{take}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetRecentProducts(int take)
    {
        var products = await _productServices.GetRecentProducts(take);
        return Ok(products);
    }

    [HttpGet("showdetail/{id}")]
    public async Task<IActionResult> ShowDetail(Guid id)
    {
        var detailResult = await _productServices.ShowDetail(id);
        return Ok(detailResult);
    }
}
