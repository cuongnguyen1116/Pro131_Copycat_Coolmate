namespace shop.Data.Entities;

public class ProductImage
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string ImagePath { get; set; }
    public string Caption { get; set; }
    public bool IsDefault { get; set; }
    //public DateTime CreatedDate { get; set; }
    public int SortOrder { get; set; }
    //public long FileSize { get; set; }
    public virtual Product Product { get; set; }
}
