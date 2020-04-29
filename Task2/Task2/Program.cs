using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput();
        }
        static void GetInput()
        {
            Console.WriteLine("Please enter number:");
            int.TryParse(Console.ReadLine(), out int number);
            CheckPrimeOrComposite(number);
            Console.ReadKey();
        }
        static void CheckPrimeOrComposite(int number)
        {
            bool checker = false;
            if (number == 2)
            {
                Console.WriteLine("Number is prime");
                return;
            }
            else if (number == 1 || number == 0)
            {
                Console.WriteLine("Neither prime, nor composite number");
                return;
            }
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    checker = true;
                }
             
            }
            if (checker)
            {
                Console.WriteLine("Number is not prime");
            }
            else
            {
                Console.WriteLine("Number is prime");
            }
        }
    }
}
