﻿namespace shop.Data.Entities;

public class Size
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductSize> ProductSizes { get; set; }
}
