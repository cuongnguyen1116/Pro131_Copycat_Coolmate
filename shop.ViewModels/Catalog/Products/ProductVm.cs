﻿using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Products;

public class ProductVm
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Image { get; set; }
    public Status Status { get; set; }
    public string SizeName { set; get; }
    public string MaterialName { get; set; }
    public string ColorName { get; set; }
}
