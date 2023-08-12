using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Common;

namespace shop.Application.Catalog.Promotions;

public interface IPromotionService
{
    Task<PagedResult<PromotionVM>> GetAll(PromotionPagingRequest request);
    Task<bool> Create(PromotionCreateRequest request);
    Task<bool> Update(Guid id, PromotionUpdateRequest request);
    Task<PromotionVM> GetById(Guid id);
}
