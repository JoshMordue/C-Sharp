using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name :");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Name: " + name + " Age: " + age);
        }
    }
}
