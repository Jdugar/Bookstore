using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BookStorePOS
{
    public enum BookGenre
    {
        Fiction,
        NonFiction,
        Fantasy,
        Mythology,
        Mystery

    };
    public class Book
    {
       
        public string Name { get; set; }
        public int BookId { get; set; }

        public string Author { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public  int ISBNNO  { get; set; }

        public BookGenre Genre { get; set; }

       // public Book()
       // {
            
     //   }
        public void AddInventory(int qty)
        {
            Quantity += qty;
        }
        public void Booksold(int qty)
        {
            Quantity -= qty;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"" +
               $"Book ID:{BookId},"+
               $"Book Name:{Name},  " +
               $"ISBN:{ISBNNO}," +
               $"Author:{Author}," +
               $"Qty:" +
               $"{Quantity}," +
               $"Unit price:{UnitPrice}");
        }


    }
}
