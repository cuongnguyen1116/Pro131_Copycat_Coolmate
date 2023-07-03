using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Catalog.Sizes;
using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration
{
    public interface IProductApiClient
    {
        
        Task<bool> CreateProduct(ProductCreateRequest request, Guid productPropId, Guid sizeId, Guid colorId, Guid materialId);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<bool> DeleteProduct(ProductDeleteRequest request);
        Task<ProductVm> GetById(Guid productDetailId);
        Task<ProductPropVm> GetByIdProductProp(Guid productPropId);
        Task<List<ProductVm>> GetAll();
        Task<bool> CreateProductProp(ProductPropVm request);
        Task<bool> UpdateProductProp(ProductPropVm request);
        Task<bool> DeleteProductProp(ProductPropVm request);
        Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request);
        Task<List<ProductPropVm>> GetListProductProp();
        Task<List<MaterialVm>> GetListMaterial();
        Task<List<ColorVm>> GetListColor();
        Task<List<SizeVm>> GetListSize();

        
    }
}
