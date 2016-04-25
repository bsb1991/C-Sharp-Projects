using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main()
        {
            const string QUIT = "ZZZ";
            string name;
            string inputString;
            double GPA;
            int admissionTest;
            Console.Write("Enter name or {0} to quit >> ", QUIT);
            name = Console.ReadLine();
            Console.WriteLine("Enter GPA ");
            inputString = Console.ReadLine();
            GPA = Convert.ToDouble(inputString);
            Console.WriteLine("Enter Test Scroe: ");
            inputString = Console.ReadLine();
            admissionTest = Convert.ToInt32(inputString);

            Console.ReadLine();



        }
        public static void isAccepted(double GPA, int admissionTest, string inputString)
        {
            try
            {
                if (GPA >= 2.5 && GPA <= 4.0 && admissionTest >= 75 && admissionTest <= 100)
                {
                    Console.WriteLine("Accepter");
                    Console.ReadLine();
                }

                else if (GPA <= 2.4 && GPA > 0.0 || (admissionTest <= 75 && admissionTest > 0 && admissionTest > 100))
                {
                    Console.WriteLine("Rejected");
                    Console.ReadLine();
                }
            }

            catch (Exception ae)
            {
                if (GPA <= 0.0 || GPA >= 4.0 || admissionTest <= 0 || admissionTest >= 100)
                {
                    Console.WriteLine("Error, GPA or Admisson Test Score does not fall within parameters" + ae);
                    Console.ReadLine();
                }
            }
        }
    }
}

