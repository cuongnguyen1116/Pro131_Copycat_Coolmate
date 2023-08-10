using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Products;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.AdminApp.Controllers;

public class ProductController : Controller
{
    private readonly IProductApiClient _productApiClient;
    private readonly ICategoryApiClient _categoryApiClient;

    public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
    {
        _productApiClient = productApiClient;
        _categoryApiClient = categoryApiClient;
    }
    [Authorize(Policy = "AdminOrManager")]
    //bảng  productdetail
    public async Task<IActionResult> Index(string? keyword, int pageIndex = 1, int pageSize = 10)
    {
        var request = new ProductPagingRequest()
        {
            Keyword = keyword,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
        var data = await _productApiClient.GetAllProductDetail(request);
        ViewBag.Keyword = keyword;
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(data);
    }
    //Bảng  product
    [Authorize(Policy = "AdminOrManager")]
    public async Task<IActionResult> ShowAllProduct(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 9)
    {
        var request = new ProductPagingRequest()
        {
            Keyword = keyword,
            CategoryId = categoryId,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
        var data = await _productApiClient.GetAllProduct(request);
        ViewBag.Keyword = keyword;
        var categories = await _categoryApiClient.GetAll();
        ViewBag.Categories = categories.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = categoryId.ToString() == x.Id.ToString()
        });
        if (TempData["result"] != null)
        {
            ViewBag.SuccessMsg = TempData["result"];
        }
        return View(data);
    }
    [HttpGet]
    [Authorize(Policy = "AdminOrManager")]
    public async Task<IActionResult> Details(Guid id)
    {
        var result = await _productApiClient.GetByIdProductDetail(id);
        ViewBag.ImagePath = result.Images;
        return View(result);
    }

    
    public async Task<IActionResult> CreateImage(string? keyword, Guid id)
    {
        var request = new ProductPagingRequest()
        {
            Keyword = keyword
        };
        var data = await _productApiClient.GetAllProduct(request);
        ViewBag.ProductImage = data.Items.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = id.ToString() == x.Id.ToString()
        });
        return View();
    }

    [HttpPost]
    [Authorize(Policy = "admin")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateImage([FromForm] ProductImageRequest request, Guid productid, string? keyword)
    {
        if (!ModelState.IsValid) { return View(); }
        var ppr = new ProductPagingRequest()
        {
            Keyword = keyword
        };
        var data = await _productApiClient.GetAllProduct(ppr);
        ViewBag.ProductImage = data.Items.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = productid.ToString() == x.Id.ToString()
        });

        var result = await _productApiClient.CreateImage(request, productid);
        if (result.IsSuccessed)
        {
            TempData["result"] = $"Thêm ảnh có caption {request.Caption} thành công";
            return RedirectToAction("Index");
        }

        ModelState.AddModelError("", "Thêm ảnh sản phẩm thất bại");
        return View(request);

    }
    // tạo mới productdetail
    [Authorize(Policy = "AdminOrManager")]
    public async Task<IActionResult> Create(Guid productId, Guid sizeId, Guid colorId, Guid materialId)
    {
        var products = _productApiClient.GetListProduct();
        ViewBag.ProductProp = products.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = productId.ToString() == x.Id.ToString()
        });
        var sizes = _productApiClient.GetListSize();
        ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = sizeId.ToString() == x.Id.ToString()
        });
        var colors = _productApiClient.GetListColor();
        ViewBag.Color = colors.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = colorId.ToString() == x.Id.ToString()
        });
        var materials = _productApiClient.GetListMaterial();
        ViewBag.Material = materials.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = materialId.ToString() == x.Id.ToString()
        });
        return View();
    }

    [HttpPost]
    [Authorize(Policy = "AdminOrManager")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Create([FromForm] ProductDetailCreateRequest request, Guid productId, Guid sizeId, Guid colorId, Guid materialId)
    {
        if (!ModelState.IsValid)
            return View(request);
        var products = _productApiClient.GetListProduct();
        ViewBag.ProductProp = products.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = productId.ToString() == x.Id.ToString()
        });
        var sizes = _productApiClient.GetListSize();
        ViewBag.Size = sizes.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = sizeId.ToString() == x.Id.ToString()
        });
        var colors = _productApiClient.GetListColor();
        ViewBag.Color = colors.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = colorId.ToString() == x.Id.ToString()
        });
        var materials = _productApiClient.GetListMaterial();
        ViewBag.Material = materials.Result.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = materialId.ToString() == x.Id.ToString()
        });
        var result = await _productApiClient.CreateProductDetail(request, productId, sizeId, colorId, materialId);
        if (result)
        {
            TempData["result"] = "Thêm mới sản phẩm thành công";
            return RedirectToAction("Index");
        }

        ModelState.AddModelError("", "Thêm sản phẩm thất bại");
        return View(request);
    }

    //tạo mới  product
    [Authorize(Policy = "AdminOrManager")]
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    [Authorize(Policy = "AdminOrManager")]
    public async Task<IActionResult> CreateProduct(ProductRequest request)
    {
        if (!ModelState.IsValid)
        {
            return View(ModelState);
        }
        var result = await _productApiClient.CreateProduct(request);
        if (result)
        {
            TempData["result"] = "Thêm mới sản phẩm thành công";
            return RedirectToAction("ShowAllProduct");
        }

        ModelState.AddModelError("", "Thêm sản phẩm thất bại");
        return View(request);
    }

    //sửa  productdetail
    [HttpGet]
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> Edit(Guid id)
    {
        var product = await _productApiClient.GetByIdProductDetail(id);
        var editvm = new ProductDetailUpdateRequest()
        {
            Id = product.Id,
            Status = product.Status,
            Stock = product.Stock,
            Price = product.Price,
        };

        return View(editvm);
    }

    [HttpPost]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Edit([FromForm] ProductDetailUpdateRequest request)
    {
        if (!ModelState.IsValid)
            return View(request);

        var result = await _productApiClient.UpdateProductDetail(request);
        if (result)
        {
            TempData["result"] = "Cập nhật sản phẩm thành công";
            return RedirectToAction("Index");
        }

        ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
        return View(request);
    }

    //sửa  product
    [HttpGet]
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> EditProduct(Guid id)
    {
        var product = await _productApiClient.GetByIdProduct(id);

        return View(product);
    }

    [HttpPost]
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> EditProduct(ProductRequest request)
    {
        if (!ModelState.IsValid)
            return View(request);

        var result = await _productApiClient.UpdateProduct(request);
        if (result)
        {
            TempData["result"] = "Cập nhật sản phẩm thành công";
            return RedirectToAction("ShowAllProduct");
        }

        ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
        return View(request);
    }

    //xóa  productdetail
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> Delete(ProductDeleteRequest request)
    {
        if (!ModelState.IsValid)
            return View();

        var result = await _productApiClient.DeleteProductDetail(request);
        if (result)
        {
            TempData["result"] = "Xóa sản phẩm thành công";
            return RedirectToAction("Index");
        }

        ModelState.AddModelError("", "Xóa không thành công");
        return View(request);
    }
    //xóa product
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> DeleteProduct(ProductDeleteRequest request)
    {
        if (!ModelState.IsValid)
            return View(ModelState);

        var result = await _productApiClient.DeleteProduct(request);
        if (result)
        {
            TempData["result"] = "Xóa sản phẩm thành công";
            return RedirectToAction("ShowAllProduct");
        }
        ModelState.AddModelError("", "Xóa không thành công");
        return View(request);
    }
    // lấy danh sách category 
    private async Task<CategoryAssignRequest> GetCategoryAssignRequest(Guid id)
    {

        var productObj = await _productApiClient.GetByIdProduct(id);
        var categories = await _categoryApiClient.GetAll();
        var categoryAssignRequest = new CategoryAssignRequest();
        foreach (var role in categories)
        {
            categoryAssignRequest.Categories.Add(new SelectItem()
            {
                Id = role.Id.ToString(),
                Name = role.Name,
                Selected = productObj.Categories.Contains(role.Name)
            });
        }
        return categoryAssignRequest;
    }
    //gán category
    [HttpGet]
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> CategoryAssign(Guid id)
    {
        var roleAssignRequest = await GetCategoryAssignRequest(id);
        return View(roleAssignRequest);
    }

    [HttpPost]
    [Authorize(Policy = "admin")]
    public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
    {
        if (!ModelState.IsValid)
            return View();

        var result = await _productApiClient.CategoryAssign(request.Id, request);

        if (result.IsSuccessed)
        {
            TempData["result"] = "Gán danh mục thành công";
            return RedirectToAction("ShowAllProduct");
        }

        ModelState.AddModelError("", result.Message);
        var roleAssignRequest = await GetCategoryAssignRequest(request.Id);

        return View(roleAssignRequest);
    }

   
}
