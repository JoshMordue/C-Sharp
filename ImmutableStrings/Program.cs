using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder first = new StringBuilder("This is a string");
            StringBuilder second = new StringBuilder("This is a string");

            Console.WriteLine($"First:  {first}");
            Console.WriteLine("Clearing First...");

            //first.Length = 0;
            //Console.WriteLine($"First:  *{first}*");

            //first.Append("Another string");
            first.Clear().Append("Another String");
            first.Clear();
            second.Clear();

            Console.WriteLine(first == second); 

            Console.WriteLine($"First:  *{first}*");



        }
    }
}
