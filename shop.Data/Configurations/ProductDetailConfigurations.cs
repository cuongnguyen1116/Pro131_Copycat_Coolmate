using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Configurations
{
    public class ProductDetailConfigurations : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x => x.Color).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ColorId);
            builder.HasOne(x => x.Material).WithMany(x => x.ProductDetails).HasForeignKey(x => x.MaterialId);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SizeId);
        }
    }
}
