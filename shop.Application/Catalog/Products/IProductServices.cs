using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Products;

public interface IProductServices
{
    Task<PagedResult<ProductDetailVm>> GetAllProductDetail(ProductPagingRequest request);
    Task<ProductDetailVm> GetByIdProductDetail(Guid productdetailId);
    Task<bool> CreateProductDetail(ProductDetailCreateRequest request);
    Task<bool> UpdateProductDetail(ProductDetailUpdateRequest request);
    Task<bool> DeleteProductDetail(Guid productdetailId);
    //Task<ProductVm> Detail(Guid productId);
    Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request);
    Task<PagedResult<ProductRequest>> GetAllProduct(ProductPagingRequest request);
    Task<List<ProductRequest>> GetListProduct();
    Task<ProductRequest> GetByIdProduct(Guid productId);
    Task<bool> CreateProduct(ProductRequest request);
    Task<bool> UpdateProduct(ProductRequest request);
    Task<bool> DeleteProduct(Guid productId);
    Task<ApiResult<bool>> AddImages(ProductImageRequest request);
    //Task<int> RemoveImages(Guid imageId);
    //Task<int> UpdateImages(Guid imageId, ProductImageRequest request);
    Task<List<ProductVm>> GetFeaturedProducts(int take);
    Task<List<ProductVm>> GetRecentProducts(int take);

}
