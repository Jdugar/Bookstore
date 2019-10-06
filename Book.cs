﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BookStorePOS
{
    enum BookGenre
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
        public int ISBN { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"" +
               $"Book Name: {Name},\n" +
               $"ISBN: {ISBN},\n" +
               $"Author: {Author},\n" +
               $"Qty: {Quantity},\n" +
               $"Unit price: {UnitPrice}");
        }

                      
    }
}