using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Configurations;

public class ProductSizeConfigurations : IEntityTypeConfiguration<ProductSize>
{
    public void Configure(EntityTypeBuilder<ProductSize> builder)
    {
        builder.HasKey(x => new { x.ProductDetailId, x.SizeId });
        builder.HasOne(x => x.ProductDetail).WithMany().HasForeignKey(x => x.ProductDetailId);
        builder.HasOne(x => x.Size).WithMany().HasForeignKey(x => x.SizeId);
        builder.Property(x => x.Status).HasDefaultValue(Status.Active);
    }
}
