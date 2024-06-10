using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public partial class CartProductDetailsConfiguration : IEntityTypeConfiguration<CartProductDetails>
    {
        public void Configure(EntityTypeBuilder<CartProductDetails> builder)
        {
            //BASE
            builder.HasKey(c => new { c.IDProductDetails, c.IDCart });
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.CreateBy).IsRequired();
            builder.Property(c => c.ModifiedBy).IsRequired(false);
            builder.Property(c => c.ModifiedDate).IsRequired(false);
            builder.Property(c => c.DeleteBy).IsRequired(false);
            builder.Property(c => c.DeleteDate).IsRequired(false);
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne<Cart>(c => c.Cart).WithMany(c => c.CartProductDetails).HasForeignKey(c => c.IDCart).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<ProductDetails>(c => c.ProductDetails).WithMany(c => c.CartProductDetails).HasForeignKey(c => c.IDProductDetails).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
