using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Configurations
{
    public class ProductImageConfigurations : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImagePath).IsRequired();
            builder.Property(x=>x.Caption).HasMaxLength(128).IsRequired();

            builder.HasOne(x => x.ProductDetail).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductDetailId);
        }
    }
}
