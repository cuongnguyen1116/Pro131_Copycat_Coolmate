using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Catalog.Sizes;
using shop.ViewModels.Common;

namespace shop.ApiIntegration.Products;

public interface IProductApiClient
{
    Task<bool> CreateProductDetail(ProductDetailCreateRequest request, Guid productId, Guid sizeId, Guid colorId, Guid materialId);
    Task<bool> UpdateProductDetail(ProductDetailUpdateRequest request);
    Task<bool> DeleteProductDetail(ProductDeleteRequest request);
    Task<ProductDetailVm> GetByIdProductDetail(Guid productDetailId);
    Task<ProductRequest> GetByIdProduct(Guid productId);
    Task<PagedResult<ProductDetailVm>> GetAllProductDetail(ProductPagingRequest request);
    Task<bool> CreateProduct(ProductRequest request);
    Task<bool> UpdateProduct(ProductRequest request);
    Task<bool> DeleteProduct(ProductDeleteRequest request);
    Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request);
    Task<List<ProductRequest>> GetListProduct();
    Task<PagedResult<ProductRequest>> GetAllProduct(ProductPagingRequest request);
    Task<List<MaterialVm>> GetListMaterial();
    Task<List<ColorVm>> GetListColor();
    Task<List<SizeVm>> GetListSize();
    Task<ApiResult<bool>> CreateImage(ProductImageRequest request, Guid productdid);
    Task<List<ProductVm>> GetFeaturedProducts(int take);
    Task<List<ProductVm>> GetRecentProducts(int take);
    Task<ShowDetailResult> ShowDetail(Guid id);
}
