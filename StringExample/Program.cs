using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Learn C# for beginners Crash Course";
            string message = "Welcome to ";

            // Concatonate CourseName to create a new string.

            string fullMessage = message + courseName;
            Console.WriteLine(fullMessage);

            //use string interpolation 
            string fullMessage2 = $"{message}{courseName}";
            Console.WriteLine(fullMessage2);

        }
    }
}
