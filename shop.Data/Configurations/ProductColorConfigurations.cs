using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Configurations;

public class ProductColorConfigurations : IEntityTypeConfiguration<ProductColor>
{
    public void Configure(EntityTypeBuilder<ProductColor> builder)
    {
        builder.HasKey(x => new { x.ProductDetailId, x.ColorId });
        builder.HasOne(x => x.Color).WithMany().HasForeignKey(x => x.ColorId);
        builder.HasOne(x => x.ProductDetail).WithMany().HasForeignKey(x => x.ProductDetailId);
        builder.Property(x => x.Status).HasDefaultValue(Status.Active);
    }
}
