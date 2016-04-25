using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    class Program
    {
        static void Main()
        {
            Bill bill1 = new Bill();
            OverdueBill bill2 = new OverdueBill();
            bill1.Name = "Gas Company";
            bill1.Amount = 30;
            bill2.Name = "Car Payment";
            bill2.Amount = 100;
            bill2.DaysOverdue = 60;
            Console.WriteLine(bill1.ToString());
            Console.ReadLine();
        }
    }
    class Bill
    {
        private string bill1;
        public P(string Boeing)
        {
            this.Boeing = Boeing;
        }
        public string Pay
        {
            get
            {
                return Boeing;
            }
        }
        public abstract string Boeing();
    }
    class Bill : Pay
    {
        public Bill(string Boeing)
            : base(Boeing)
        {
        }
        public override string Speak()
        {
            return "You Regular Bill is due for an amount of: $426.00";
        }
    }
    class Overdue : Pay
    {
        public OverdueBill(string Boeing)
            : base(Boeing)
        {
        }
        public override string Boeing()
        {
            return "You have an overdue balance of $852.00 and its late 31 days";
        }
    }
}



