using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class PalindromeChecker
    {

        private static int textIter;
        private static int lastChar;

        static void Main(string[] args)
        {
            string inputText;

            System.Console.WriteLine("****************");
            Console.WriteLine("Please enter a word/Sentence and we see if it is a palindrome.");
            Console.WriteLine("Please note when comparing a sentence spaces will not be considered.");
            while (true) {

                inputText = Console.ReadLine();
                bool isAlpha = Regex.IsMatch(inputText, @"^[a-zA-Z]+$");
                Console.WriteLine(isAlpha);

                if (!String.IsNullOrWhiteSpace(inputText) && (isAlpha == true))
                {
                    Console.WriteLine($"{inputText} was entered.");
                    InputCheck(inputText);
                }
                else
                {
                    Console.WriteLine($"{inputText} was not valid, Please ensure the word entered is not using numbers");
                }

            }
        }

        public static string InputCheck(string Text) 
        {

            lastChar = Text.Count() - 1;
            textIter = (lastChar / 2);

            Console.WriteLine(lastChar);
            Console.WriteLine(textIter);

            for (int i = 0; i < textIter; i += 1)
            {
                if (Text[i] < Text[lastChar])
                {
                    Console.WriteLine("Not palindrome");
                    break;
                }

                lastChar -= 1;
                Console.WriteLine(i);
                Console.WriteLine(textIter);
                Console.WriteLine(lastChar);

            }

            Console.WriteLine($"{Text} is a palindrome");
            return Text;
        }
    }
}
