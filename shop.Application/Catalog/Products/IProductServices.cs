﻿using shop.ViewModels.Catalog.Categories;
using shop.ViewModels.Catalog.Products;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Products;

public interface IProductServices
{
    Task<List<ProductVm>> GetAll();
    Task<ProductVm> GetById(Guid productdetailId);
    Task<bool> Create(ProductCreateRequest request);
    Task<bool> Update(ProductUpdateRequest request);
    Task<bool> Delete(Guid productdetailId);
    Task<ApiResult<bool>> CategoryAssign(Guid id, CategoryAssignRequest request);
    Task<List<ProductPropVm>> GetAllProductProp();
    Task<ProductPropVm> GetByIdProductProp(Guid productPropId);
    Task<bool> CreateProductProp(ProductPropVm request);
    Task<bool> UpdateProductProp(ProductPropVm request);
    Task<bool> DeleteProductProp(Guid productPropId);

}
