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
            StringBuilder first = new StringBuilder("The values are");

            int a = 12;
            int b = 34;
            int c = 56;

            //first.AppendFormat("a = {0}, b = {1}, c = {2}", a, b, c);
            first.AppendLine(":");
            first.Append($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine(first);

            first.Append(12.ToString());
            first.Append(' '.ToString());
            first.Append(3.45.ToString());
            first.Append(' '.ToString());
            first.Append(a == 12).ToString();

            first.Append(' '.ToString());
            first.Append(b > c).ToString();

            first.AppendLine().Append('*', 40); 
            Console.WriteLine(first);




        }
    }
}
