using shop.ViewModels.Catalog.Promotions;
using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Catalog.Promotions
{
    public interface IPromotionService
    {
        Task<PagedResult<PromotionVM>> GetAll(PromotionPagingRequest request);
        Task<bool> Create(PromotionCreateRequest request);
        Task<bool> Update(Guid id, PromotionUpdateRequest request);
        Task<PromotionVM> GetById(Guid id);
    }
}
