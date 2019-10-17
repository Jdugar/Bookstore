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
                Console.WriteLine("Enter A to Add new book to Inventory");
                Console.WriteLine("Enter P to Print all books in inventory");
                Console.WriteLine("E. Exit");
                Console.WriteLine("----------------------------");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("Adding new book");
                        Console.Write("Enter Book Name: ");
                        var bookname = Console.ReadLine();
                        Console.Write("Enter Author Name: ");
                        var author = Console.ReadLine();
                        Console.WriteLine("Enter BookGenre: ");
                        var genres = Enum.GetNames(typeof(BookGenre));
                        for (int i = 0; i < genres.Length; i++)
                        {
                            Console.WriteLine($"{i}. {genres[i]}");
                        }
                        var genre = Enum.Parse<BookGenre>(Console.ReadLine());
                        Console.WriteLine("Quantity");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Price per unit");
                        var unitprice = Convert.ToInt32(Console.ReadLine());
                                    

                        BookStore.AddNewBook(bookname, author, quantity,unitprice, genre);
                        


                        break;
                    case "P":
                        BookStore.PrintAllBooks();
                        break;
                    case "E":
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
