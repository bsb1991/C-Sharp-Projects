using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesOne = new string[1];
            string[] namesTwo = new string[2];
            string[] namesFive = new string[5];
            string[] namesTen = new string[10];
        
            int names;
            string howMany;
            Console.WriteLine("How many names do you want to sort, 1, 2, 5, 10?");
            howMany = Console.ReadLine();
            names = Convert.ToInt32(howMany);

            switch (names)
            {
                case 1:
                Console.WriteLine("Please enter the first name");
               
               for (int i = 0; i < namesOne.Length; i++)
                 {
                    namesOne[i] = Console.ReadLine();
                 }
                Array.Sort(namesOne);
                Console.WriteLine("The sorted names are:{0}", namesOne);
                Console.ReadLine();
                break;

                case 2:

                for (int i = 0; i < namesTwo.Length; i++)
                {
                    Console.WriteLine("Please enter a name");
                    namesTwo[i] = Console.ReadLine();
                }
                
                Array.Sort(namesTwo);
                Console.WriteLine("The sorted names are: {0},{1}",namesTwo);
                Console.ReadLine();
                break;
                    
                case 5:
                
                for (int i = 0; i < namesFive.Length; i++)
                {
                    Console.WriteLine("Please enter a name");
                    namesFive[i] = Console.ReadLine();
                }
                
                Array.Sort(namesFive);
                Console.WriteLine("The sorted names are: {0},{1},{2},{3},{4}", namesFive);
                Console.ReadLine();
                break;

                case 10:
                 for (int i = 0; i < namesTen.Length; i++)
                 {
                     Console.WriteLine("Please enter a name");
                     namesTen[i] = Console.ReadLine();
                 }       
                
                            Array.Sort(namesTen);
                            Console.WriteLine("The sorted names are: {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", namesTen);
                            Console.ReadLine();
                            break;
            } 
        }
    }
}
