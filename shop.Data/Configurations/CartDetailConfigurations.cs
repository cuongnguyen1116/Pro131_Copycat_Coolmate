﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Configurations
{
    public class CartDetailConfigurations : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(x => new { x.ProductDetailId, x.UserId });
            builder.Property(x=>x.Quantity).IsRequired();
            builder.Property(x=>x.Price).IsRequired();

            builder.HasOne(x => x.Cart).WithMany(x => x.CartDetails).HasForeignKey(x => x.UserId);
        }
    }
}
