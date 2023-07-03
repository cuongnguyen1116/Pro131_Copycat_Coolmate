using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shop.ApiIntegration;
using shop.Utilities.Constants;
using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.AdminApp.Controllers
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
        public async Task<IActionResult> Index()
        {
            var data = await _productApiClient.GetAll();
            
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        //Bảng  productdetail
        public async  Task<IActionResult> Create(Guid productPropId, Guid sizeId, Guid colorId, Guid materialId)
        {
            var productprops = _productApiClient.GetListProductProp();
            ViewBag.ProductProp = productprops.Result.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = productPropId.ToString() == x.Id.ToString()
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
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request, Guid productPropId, Guid sizeId, Guid colorId, Guid materialId)
        {
            if (!ModelState.IsValid)
                return View(request);
            var productprops = _productApiClient.GetListProductProp();
            ViewBag.ProductProp = productprops.Result.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = productPropId.ToString() == x.Id.ToString()
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
            var result = await _productApiClient.CreateProduct(request,  productPropId,  sizeId,  colorId,  materialId);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }
        //Bảng  product
        public async Task<IActionResult> CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductPropVm request)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var result = await _productApiClient.CreateProductProp(request);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("ShowAllProductProp");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }
        //Bảng  productdetail
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _productApiClient.GetById(id);
            var editvm = new ProductUpdateRequest()
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
        public async Task<IActionResult> Edit([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productApiClient.UpdateProduct(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }
        //Bảng  product
        [HttpGet]
        public async Task<IActionResult> EditProduct(Guid id)
        {
            var product = await _productApiClient.GetByIdProductProp(id);
            
            return View(product);
        }

        [HttpPost]

        public async Task<IActionResult> EditProduct(ProductPropVm request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productApiClient.UpdateProductProp(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                return RedirectToAction("ShowAllProductProp");
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }
        //Bảng  productdetail
        public async Task<IActionResult> Delete(ProductDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.DeleteProduct(request);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
        //Bảng  product
        [HttpGet]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _productApiClient.GetByIdProductProp(id);
            if (product == null)
            {
                return NotFound();
            }

            var productPropVm = new ProductPropVm
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Status = product.Status
            };

            return View(productPropVm);
        }
        [HttpPost]    
        public async Task<IActionResult> DeleteProduct(ProductPropVm request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productApiClient.DeleteProductProp(request);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("ShowAllProductProp");
            }
            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(Guid id)
        {
            
            var productObj = await _productApiClient.GetByIdProductProp(id);
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

        [HttpGet]
        public async Task<IActionResult> CategoryAssign(Guid id)
        {
            var roleAssignRequest = await GetCategoryAssignRequest(id);
            return View(roleAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.CategoryAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("ShowAllProductProp");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetCategoryAssignRequest(request.Id);

            return View(roleAssignRequest);
        }
        //Bảng  product
        public async Task<IActionResult> ShowAllProductProp(Guid categoryId)

        {
            var data = await _productApiClient.GetListProductProp();
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
    }
}
