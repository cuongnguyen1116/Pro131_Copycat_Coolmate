﻿using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Promotions
{
    public class PromotionUpdateRequest
    {
        public Guid Id { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime FinishDate { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public PromotionStatus Status { set; get; }
    }
}
