using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it?");

            string day = Console.ReadLine();
            string HowToSpendTime;

            HowToSpendTime = day.ToLower().Equals("saturday") ? "Relax" : "Work";

            Console.WriteLine($"{HowToSpendTime} on {day}");
        }
    }
}
