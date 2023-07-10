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
            //int answer = 7 + 3 * 4;
            //Console.WriteLine(answer);

            //double radius = 12;
            //double area = Math.PI * radius * radius;

            //Console.WriteLine(area);

            //int x = 3;
            //int y = x++;

            //Console.WriteLine($"Using X++, X is : {x} and Y is: {y}");

            //x = 3;
            //y = ++x;
            //Console.WriteLine($"Using X++, X is : {x} and Y is: {y}");

            double a = 12 * 3 / 4.0;
            double b = (12 * 3) / 4.0;
            double c = 12 * (3 / 4.0);

            Console.WriteLine($"{a}, {b}, {c}");
            Console.WriteLine();

            double d = 12.0 / 3.0 / 4.0;
            double e = (12.0 / 3.0) / 4.0;
            double f = 12.0 / (3.0 / 4.0);
            double g = 120 / (3.0 / 4.0);

            Console.WriteLine($"{d}, {e}, {f}, {g}");
            Console.WriteLine();

            int x = 12 + 3 - 4;
            int y = (12 + 3) - 4;
            int z = 12 + (3 - 4);

            Console.WriteLine($"{x}, {y}, {z}");

        }
    }
}
