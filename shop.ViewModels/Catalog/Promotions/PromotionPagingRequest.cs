using shop.Data.Enums;
using shop.ViewModels.Common;

namespace shop.ViewModels.Catalog.Promotions
{
    public class PromotionPagingRequest : PagingRequestBase
    {
        public string? KeyWord { get; set; }
        public string? PromotionCode { get; set; }
        public PromotionStatus Status { get; set; }
    }
}
