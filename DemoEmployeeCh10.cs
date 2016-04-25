using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemooEmployees
{
    class Program
    {
        static void Main()
        {
            Employee clerk = new Employee();
            CommissionEmployee salesperson = new CommissionEmployee();
            clerk.EmpNum = 123;
            clerk.EmpSal = 30000.00;
            salesperson.EmpNum = 234;
            salesperson.EmpSal = 20000;
            salesperson.CommissionRate = 0.07;
            Console.WriteLine("\n" + clerk.GetGreeting());
            Console.WriteLine("Clerk #{0} salary: {1} per year", clerk.EmpNum, clerk.EmpSal.ToString("C"));
            Console.WriteLine("\n" + salesperson.GetGreeting());
            Console.WriteLine("Salesperson #{0} salary: {1} per year", salesperson.EmpNum, salesperson.EmpSal.ToString("C"));
            Console.WriteLine("...plus {0} comission on all sales", salesperson.CommissionRate.ToString("P"));
          //  CommissionEmployee salesperson = new CommissionEmployee();
            salesperson.EmpNum = 345;
            Console.WriteLine(salesperson.GetGreeting());
            Console.ReadLine();

        }
            
        }
    }
    class Employee
    {
        private int empNum;
        protected double empSal;
        public int EmpNum
        {
            get
            {
                return empNum;
            }
            set
            {
                empNum = value;
            }
        }
        public double EmpSal
        {
            get
            {
                return empSal;
            }
            set
            {
                empSal = value;
            }
        }
        public string GetGreeting()
        {
            string greeting = "Hello. I am employee #" + EmpNum;
            return greeting;
        }
    }
    class CommissionEmployee : Employee
    {
        private double commissionRate;
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
                empSal = 0;
            }
        }
        new public string GetGreeting()
        {
            string greeting = base.GetGreeting();
            greeting += "\nI work on comission.";
            return greeting;



        }
    }
  



