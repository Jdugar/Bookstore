using Bookstore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace BookStorePOS
{
    public static class BookStore
    {
        private static BookContext db = new BookContext();

        public static Book AddNewBook(String name, String author, int quantity, Decimal unitprice, BookGenre genre, int ISBNNo)
        {
            var book = new Book
            {
                Name = name,
                Author = author,
                Quantity = quantity,
                UnitPrice = unitprice,
                Genre = genre,
                ISBNNO = ISBNNo,
            };
            db.books.Add(book);
            db.SaveChanges();
            Console.WriteLine("Book added successfully.\n");
            return book;
        }
        public static void PrintAllBooks()
        {
            Console.WriteLine("The book store has the following books:");
            foreach (var book in db.books)
            {
                book.DisplayBookInfo();
            }
            Console.WriteLine("-------");
        }
        //public static IEnumerable<Book>GetBookQTYbyName(string BookName, int qty)
        //{
        // var book=books.Where(a => a.Name == BookName);
        //book.UpdateInventory(qty);

        //}
        public static void AddInventory(String bookname, int qty)
        {
            var book = db.books.SingleOrDefault(a => a.Name == bookname);
            if (book == null)
            {
                return;
            }
            book.AddInventory(qty);

            var booktransaction = new BookTransaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = TypesofTransaction.purchase,
                Bookname = bookname,
                Quantity = qty,
                updatedQuantity = book.Quantity,
               bookid = book.BookId,


            };
            db.booktransactions.Add(booktransaction);
            db.SaveChanges();
        }
        public static void Booksold(String bookname, int qty)
        {
            var book = db.books.SingleOrDefault(a => a.Name == bookname);
            if (book == null)
            {
                return;
            }
            book.Booksold(qty);
            {
                var booktransaction1= new BookTransaction
                {

                      TransactionDate = DateTime.Now,
                TransactionType = TypesofTransaction.purchase,
                Bookname = bookname,
                Quantity = qty,
                updatedQuantity = book.Quantity,
                bookid = book.BookId,
            };
            db.booktransactions.Add(booktransaction1);
                db.SaveChanges();
            }


            //public void PrintAllBooks()
            //{
            //    for (int i = 0; i < NumberOfBooks; i++)
            //    {
            //        Console.WriteLine(books[i].Name);
            //    }
            //}
        }
    }
}

        