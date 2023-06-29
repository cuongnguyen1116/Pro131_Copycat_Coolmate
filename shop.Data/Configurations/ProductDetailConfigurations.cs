using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class ProductDetailConfigurations : IEntityTypeConfiguration<ProductDetail>
{
    public void Configure(EntityTypeBuilder<ProductDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Stock).IsRequired();
        builder.Property(x => x.Price).IsRequired();
        builder.Property(x => x.OriginalPrice).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();

        builder.HasOne(x => x.Product).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProductId);
    }
}
