using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;

            Console.WriteLine($"x = {x}, y = {y}");

            Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");

            string first = "This is a string";
            string second = first;

            Console.WriteLine($"First:  {first}");
            Console.WriteLine($"Second:  {second}");
            Console.WriteLine($"First is the same as second: {object.ReferenceEquals(first, second)}");
        }
    }
}
