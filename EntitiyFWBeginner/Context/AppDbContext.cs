using EntitiyFWBeginner.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFWBeginner.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Sample1;User Id=sa;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasQueryFilter(p=>p.status!=EntitiyFWBeginner.Model.Abstract.Status.Passive);

            modelBuilder.Entity<Product>().HasQueryFilter(p => p.status != EntitiyFWBeginner.Model.Abstract.Status.Passive);

            base.OnModelCreating(modelBuilder);
        }

    }
}
