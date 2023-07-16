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


            int position;

            position = courseName.IndexOf("c", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(position);





            //string message = "Welcome to ";

            //// Concatonate CourseName to create a new string.

            //string fullMessage = message + courseName;
            //Console.WriteLine(fullMessage);

            ////use string interpolation 
            //string fullMessage2 = $"{message}{courseName}";
            //Console.WriteLine(fullMessage2);


            ////use composite formatting with methods that support it
            //Console.WriteLine("Hello, and {0} the {1}", message, courseName);

            //for (int i = 0; i < courseName.Length; i++)
            //{
            //    char character = courseName[i];
            //    Console.WriteLine(character);
            //}
        }
    }
}
