using BookStorePOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    enum TypesofTransaction
    {
        purchase,
        Sell
    }
    class BookTransaction
    {
            public int TransactionID { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Bookname { get; set; }
            public int Quantity { get; set; }
            public TypesofTransaction TransactionType { get; set; }
            public decimal unitPrice  { get; set; }
            public int bookid { get; set; }
            public decimal TransactionAmount { get; set; }
            public int updatedQuantity { get; set; }
        public virtual Book Book{ get; set; }


    }
    }
