using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace BookStorePOS
{
    public static class BookStore
    {
        private static List<Book> books = new List<Book>();
        public static Book AddNewBook(String name, String author, int quantity, Decimal unitprice, BookGenre genre)
        {
            var book = new Book
            {
                Name = name,
                Author = author,
                Quantity = quantity,
                UnitPrice = unitprice,
                Genre = genre,
            };
            books.Add(book);
            Console.WriteLine("Book added successfully.\n");
            return book;


        }
        public static void PrintAllBooks()
        {
            Console.WriteLine("The book store has the following books:");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
            Console.WriteLine("-------");
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
