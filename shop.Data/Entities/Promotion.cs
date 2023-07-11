using shop.Data.Enums;

namespace shop.Data.Entities;

public class Promotion
{
    public int Id { set; get; }
    public string PromotionCode { set; get; }
    public DateTime StartDate { set; get; }
    public DateTime FinishDate { set; get; }
    public int? DiscountPercent { set; get; }
    public decimal? DiscountAmount { set; get; }
    public bool PromotionCondition { get; set; } // không biết xử lý sao cả
    public Status Status { set; get; }
}
