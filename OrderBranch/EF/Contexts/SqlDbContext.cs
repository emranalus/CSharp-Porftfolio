using Microsoft.EntityFrameworkCore;
using OrderManagement.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBranch.EF.Contexts
{
    public class SqlDbContext : DbContext
    {

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public ICollection<Siparis> siparisler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CodeFirst is King!
            // Thats how you assign Properties like in the Sql Management Studio but with code
            // Somebody has to do it :)
            modelBuilder.Entity<Customer>()
                .Property(p => p.Email)
                .HasMaxLength(80)
                .IsRequired(true);

        }

    }
}
