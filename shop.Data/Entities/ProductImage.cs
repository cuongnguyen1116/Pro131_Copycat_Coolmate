namespace shop.Data.Entities;

public class ProductImage
{
    public Guid Id { get; set; }
    public Guid ProductDetailId { get; set; }
    public string ImagePath { get; set; }
    public string Caption { get; set; }
    public bool IsDefault { get; set; }
    //public DateTime CreatedDate { get; set; }
    public int SortOrder { get; set; }
    //public long FileSize { get; set; }
    public virtual ProductDetail ProductDetail { get; set; }
}
