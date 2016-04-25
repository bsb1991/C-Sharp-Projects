using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTwoBooks
{
    class Program
    {
        static void Main()
        {
            Book myBook = new Book();
            Book yourBook = new Book();
            myBook.Title = "Silas Marner";
            yourBook.Title = "The Time Travelers Wofe";
            myBook.AdvertisingMessage();
            yourBook.AdvertisingMessage();
            Console.ReadLine();
        }
    }
    class Book
    {
        private double price;
        private double tax;
        private double price;
        public void SetPriceAndTax(double price)
        {
            const double TAX_RATE = 0.07;
            this.price = price;
            tax = price * TAX_RATE;
        }
    }
    class Book
    {
        private double price;
        private double tax;
        private double price;
        public void SetPriceAndTax(double price)
        {
            const double TAX_RATE = 0.07;
            this.price = price;
            tax = price * TAX_RATE;
        }
    
        private string title;
        private int numpages;
        private double price;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public void AdvertisingMessage()
        {
            Console.WriteLine("Buy it now: {0}", this.Title);
        }
    }
}
