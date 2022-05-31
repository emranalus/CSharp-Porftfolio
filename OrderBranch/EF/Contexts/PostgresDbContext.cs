using Microsoft.EntityFrameworkCore;
using OrderBranch.EF.Configurations;
using OrderManagement.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBranch.EF.Contexts
{
    public class PostgresDbContext : DbContext
    {

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public ICollection<Siparis> siparisler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Server=localhost;Database=yeehaw;User Id=postgres;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Doing it like that does not violate Single Responsibility
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly();
        }

    }
}
