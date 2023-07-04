using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 7 + 3 * 4;
            Console.WriteLine(answer);

            double radius = 12;
            double area = Math.PI * radius * radius;

            Console.WriteLine(area);

            int x = 3;
            int y = x++;

            Console.WriteLine($"Using X++, X is : {x} and Y is: {y}");

            x = 3;
            y = ++x;
            Console.WriteLine($"Using X++, X is : {x} and Y is: {y}");
        }
    }
}
