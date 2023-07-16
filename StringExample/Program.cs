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
            //                             1         2         3
            //                   01234567890123456789012345678901234
            string courseName = "Learn C# for Beginners Crash Course";

            int position = -1;

            do
            {
                position = courseName.IndexOf(" c", position + 1, StringComparison.OrdinalIgnoreCase);
                if (position != -1)
                {
                    courseName = ReplaceByIndex(courseName, position, " c".Length, " Java");
                    Console.WriteLine(courseName);
                }
            } while (position != -1);

            string fixedString = courseName.Replace(" Java", " C");
            Console.WriteLine(fixedString);
        }

        private static string ReplaceByIndex(string original, int start, int length, string replacement)
        {
            string NewString = original.Remove(start, length);
            return NewString.Insert(start, replacement);
        }

    }
}

