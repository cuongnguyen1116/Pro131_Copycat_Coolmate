using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Products;

public interface IProductServices
{
    Task<PagedResult<ProductVm>> GetAll(ProductPagingRequest request);
    Task<ProductVm> GetById(Guid productdetailId);
    Task<bool> Create(ProductCreateRequest request);
    Task<bool> Update(ProductUpdateRequest request);
    Task<bool> Delete(Guid productdetailId);
    Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request);
    Task<List<ProductPropRequest>> GetAllProductProp(ProductPagingRequest request);
    Task<List<ProductPropRequest>> GetListProductProp();
    Task<ProductPropRequest> GetByIdProductProp(Guid productPropId);
    Task<bool> CreateProductProp(ProductPropRequest request);
    Task<bool> UpdateProductProp(ProductPropRequest request);
    Task<bool> DeleteProductProp(Guid productPropId);
    Task<ApiResult<bool>> AddImages(ProductImageRequest request);
    //Task<int> RemoveImages(Guid imageId);
    //Task<int> UpdateImages(Guid imageId, ProductImageRequest request);
    Task<List<ProductPropVM>> GetFeaturedProducts(int take);
    Task<List<ProductPropVM>> GetRecentProducts(int take);

}
