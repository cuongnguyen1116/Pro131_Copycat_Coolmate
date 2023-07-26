using shop.Data.Enums;
using shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Promotions
{
    public class PromotionPagingRequest : PagingRequestBase
    {
        public string? KeyWord { get; set; }
        public string? PromotionCode { get; set; }
        public PromotionStatus Status { get; set; }
    }
}
