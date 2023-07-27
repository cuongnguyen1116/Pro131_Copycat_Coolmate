using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Promotions
{
    public class PromotionVM
    {
        public Guid Id { set; get; }
        public string PromotionCode { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime FinishDate { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }        
        public PromotionStatus Status { set; get; }
    }
}
