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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //BASE
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.AdressType).IsRequired();
            builder.Property(c => c.ParentID).IsRequired();

            builder.HasOne<ApplicationUser>(c => c.ApplicationUser)
                .WithMany(c => c.Addresss)
                .HasForeignKey(c => c.IDUser)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
