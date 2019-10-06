using System;

namespace BookStorePOS
{
    class Program
    {
        static void Main(string[] args)
        {

            BookStore bkStore = new BookStore();

            var book = new Book
            {
                Name = "Tree House",
                ISBN = 111,
                Author = "Mary Pop",
                Quantity = 10,
                UnitPrice = 5
            };
            book.DisplayBookInfo();
            bkStore.AddBookToStore(book);
         
            var book1 = new Book
            {
                Name = "Harry Potter",
                ISBN = 222,
                Author = "J K Rowling",
                Quantity = 20,
                UnitPrice = 10
            };
            book1.DisplayBookInfo();
            bkStore.AddBookToStore(book1);

            bkStore.PrintAllBooks();

        }
    }
}
