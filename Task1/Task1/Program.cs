using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            GetInput();
            Console.ReadLine();
        }

        static void GetInput()
        {
            Console.WriteLine("Please enter number:");
            int.TryParse(Console.ReadLine(), out int number);
            GetNumberOfDigits(number);
        }
        static void GetNumberOfDigits(int number)
        {
            int counter = 0;
            if (number < 0)
            {
                number *= (-1);
            }
            else if (number == 0)
            {
                counter = 1;
                Console.WriteLine($"Number of digits:{counter}");
                return;
            }
            while (number > 0)
            {
                number /= 10;
                counter++;
            }
            Console.WriteLine($"Number of digits:{counter}");
        }
    }
}
