using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BookStorePOS
{
    public class BookStore
    {
        public Book[] books { get; set; }
        public int NumberOfBooks = 0;
        
        public BookStore()
        {
            books = new Book[100];
        }
        public void AddBookToStore(Book newBook)
        {
            books[NumberOfBooks] = newBook;
            NumberOfBooks++;
        }
        public void PrintAllBooks()
        {
            for (int i = 0; i < NumberOfBooks; i++)
            {
                Console.WriteLine(books[i].Name);
            }
        }
    }
}
