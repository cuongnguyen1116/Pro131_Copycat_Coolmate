using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Configurations;

public class OrderDetailConfigurations : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(x => new { x.ProductDetailId, x.OrderId });
        builder.Property(x => x.Quantity).IsRequired();
        builder.Property(x => x.Price).IsRequired();
        builder.Property(x => x.Status).HasDefaultValue(Status.Active);
    }
}
