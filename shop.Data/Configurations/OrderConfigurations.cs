using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class OrderConfigurations : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.ShipName).HasMaxLength(128).IsRequired();
        builder.Property(x => x.ShipAddress).IsRequired();
        builder.Property(x => x.ShipPhoneNumber).IsRequired();

        builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
    }
}
