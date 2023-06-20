using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            while (true)
            {

                userNumber = Console.ReadLine("Please enter a number you want to check whether it is prime: ");

                if (checkNumber(userNumber))
                {
                    Console.WriteLine($"{userNumber} is a prime number.");

                }
                else
                {
                    Console.WriteLine($"{userNumber} is not a prime number.");
                }

            }

            static bool checkNumber(int Number)
            {
                if (Number <= 1) return false;
                if (Number == 2) return true;
                if (Number % 2 == 0) return false;

                int boundary = (int)Math.Floor(Math.Sqrt(Number));

                for (int i = 3; i <= boundary; i += 2)
                    if (Number % i == 0)
                        return false;

            }


        }

    }


}

