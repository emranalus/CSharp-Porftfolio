using BookEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDAL.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BooksAuthors> BooksAuthors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set Primary Keys
            modelBuilder
                .Entity<BooksAuthors>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            // Set Foreign Keys
            // One book to many author
            modelBuilder
                .Entity<BooksAuthors>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BooksAuthors)
                .HasForeignKey(ba=>ba.BookId);

            // Set Foreign Keys
            // One author to many books
            modelBuilder
                .Entity<BooksAuthors>()
                .HasOne(ba => ba.Author)
                .WithMany(b => b.BooksAuthors)
                .HasForeignKey(ba => ba.AuthorId);

        }
    }
}
