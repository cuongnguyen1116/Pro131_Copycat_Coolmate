using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Promotions
{
    public interface IPromotionApiClient
    {
        Task<PagedResult<PromotionVM>> GetAll(PromotionPagingRequest request);
        Task<PromotionVM> GetById(Guid id);
        Task<bool> CreatePromotion(PromotionCreateRequest collection);
        Task<bool> UpdatePromotion(PromotionUpdateRequest collection);
    }
}
