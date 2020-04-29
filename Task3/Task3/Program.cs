using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput();

            Console.ReadKey();
        }

        static void GetInput()
        {
            Console.WriteLine("Please enter month number:");
            int.TryParse(Console.ReadLine(), out int monthNumber);
            FindTheMonth(monthNumber);
        }
        static void FindTheMonth(int monthNumber)
        {
            if(monthNumber==12||monthNumber==1|| monthNumber == 2)
            {
                Console.WriteLine("You are in winter");
            }
            else if (monthNumber >=3&& monthNumber <= 5)
            {
                Console.WriteLine("You are in spring");
            }
            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                Console.WriteLine("You are in summer");
            }
           else if (monthNumber >= 9 && monthNumber <= 11)
            {
                Console.WriteLine("You are in autumn");
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
