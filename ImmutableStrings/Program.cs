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
            StringBuilder second = first;

            Console.WriteLine($"First:  {first}");
            Console.WriteLine($"Second:  {second}");
            Console.WriteLine($"First is the same as second: {object.ReferenceEquals(first, second)}");

            Console.WriteLine();

            first = first.Remove(4, 5);
            //first = first.Insert(4, " is a");
            Console.WriteLine($"First:  {first}");
            Console.WriteLine($"Second:  {second}");
            Console.WriteLine();
            Console.WriteLine($"First is the same as second: {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");
            Console.WriteLine($"First .Equals second: {first.Equals(second)}");




        }
    }
}
