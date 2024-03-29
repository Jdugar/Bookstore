﻿// <auto-generated />
using System;
using Bookstore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookstore.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20191111043147_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookstore.BookTransaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bookname");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TransactionAmount");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TransactionType");

                    b.Property<int>("bookid");

                    b.Property<decimal>("unitPrice");

                    b.Property<int>("updatedQuantity");

                    b.HasKey("TransactionID")
                        .HasName("Pk_Transaction");

                    b.HasIndex("bookid");

                    b.ToTable("booktransactions");
                });

            modelBuilder.Entity("BookStorePOS.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasMaxLength(100);

                    b.Property<int>("Genre");

                    b.Property<int>("ISBNNO");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("BookId")
                        .HasName("Pk_Accounts");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Bookstore.BookTransaction", b =>
                {
                    b.HasOne("BookStorePOS.Book", "Book")
                        .WithMany()
                        .HasForeignKey("bookid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
