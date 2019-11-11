using BookStorePOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    class BookContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<BookTransaction> booktransactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bookstore;Integrated Security=True;Connect Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(a => a.BookId).HasName("Pk_Accounts");

                entity.Property(a => a.BookId).ValueGeneratedOnAdd();


                entity.Property(a => a.Name).IsRequired().HasMaxLength(100);
                entity.Property(a => a.Author).HasMaxLength(100);
                entity.Property(a => a.Genre).IsRequired();
                entity.Property(a => a.ISBNNO).IsRequired();
                entity.Property(a => a.Quantity).IsRequired();
                entity.Property(a => a.UnitPrice).IsRequired();
                entity.ToTable("Book"); ;
            });
            modelBuilder.Entity<BookTransaction>(entity =>
            {
                entity.HasKey(a => a.TransactionID).HasName("Pk_Transaction");

                entity.Property(a => a.TransactionID).ValueGeneratedOnAdd();

                entity.Property(a => a.TransactionType).IsRequired();
                entity.HasOne(a => a.Book).WithMany().HasForeignKey(a => a.bookid);

            });
        }
    }
}
