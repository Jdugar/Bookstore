using System;
using System.Collections;
using System.Diagnostics;

namespace BookStorePOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Saahil's Bookstore");

            while (true)
            {

                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter 1 to Add new book to Inventory");
                Console.WriteLine("Enter 2 to Print all books in inventory");
                Console.WriteLine("Enter 3 to Add Book to Inventory" );
                Console.WriteLine("Enter 4 to Sell Book");
                Console.WriteLine("Enter 5 to Exit");
                Console.WriteLine("----------------------------");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Writeline("Adding new book");
                        Console.WriteLine("---------------------");
                        Console.Write("Enter Book Name:");
                        var bookname = Console.ReadLine();
                        Console.Write("Enter Author Name:");
                        var author = Console.ReadLine();
                        Console.Write("Enter BookGenre:");
                        var genres = Enum.GetNames(typeof(BookGenre));
                        for (int i = 0; i < genres.Length; i++)
                        {
                            Console.WriteLine($"{i}. {genres[i]}");
                        }
                        var genre = Enum.Parse<BookGenre>(Console.ReadLine());
                        Console.Write("Quantity:");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Price per unit:");
                        var unitprice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("ISBN No:");
                        var isbnno = Convert.ToInt32(Console.ReadLine());
                                    

                        BookStore.AddNewBook(bookname, author, quantity,unitprice, genre, isbnno);
                          break;
                    case "2":
                        BookStore.PrintAllBooks();
                        break;
                    case "3":
                        Console.Write("Enter the Book name to update the Inventory:");
                        var book = Console.ReadLine();
                        Console.Write("enter the qty:");
                        var qty = Convert.ToInt32(Console.ReadLine());
                        BookStore.AddInventory(book,qty);
                        Console.Write("Book Inventory updated!");
                        break;
                    case "4":
                        Console.Write("Enter the Book name to Sell:");
                        book = Console.ReadLine();
                        Console.Write("enter the qty:");
                        qty = Convert.ToInt32(Console.ReadLine());
                        BookStore.Booksold(book, qty);
                        Console.Write("Book Inventory updated!");
                        break;

                    case "5":
                        Console.WriteLine("Exiting Program");
                        return;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            }
            //BookStore bkStore = new BookStore();

            //var book = new Book
            //{
            //    Name = "Tree House",
            //    ISBN = 111,
            //    Author = "Mary Pop",
            //    Quantity = 10,
            //    UnitPrice = 5
            //};
            //book.DisplayBookInfo();
            //bkStore.AddBookToStore(book);

            //var book1 = new Book
            //{
            //    Name = "Harry Potter",
            //    ISBN = 222,
            //    Author = "J K Rowling",
            //    Quantity = 20,
            //    UnitPrice = 10
            //};
            //book1.DisplayBookInfo();
            //bkStore.AddBookToStore(book1);

            //bkStore.PrintAllBooks();

        }
    }
}
