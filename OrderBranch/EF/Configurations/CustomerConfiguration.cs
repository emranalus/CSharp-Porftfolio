using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagement.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBranch.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            // CodeFirst is King!
            // Thats how you assign properties like in the Sql Management Studio but with code
            // Somebody has to do it :)
            builder.Property(p => p.CustomerCode)
                .HasMaxLength(50)
                .HasDefaultValue("0000")
                .IsRequired(true);

            builder.Property(p => p.Email)
                .HasMaxLength(80)
                .IsRequired(true);

            builder.Property(p => p.Gsm)
                .HasMaxLength(11)
                .IsRequired(true);

        }

    }
}
