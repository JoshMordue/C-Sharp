using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class PalindromeChecker
    {
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
            Console.WriteLine(Text);
            return Text;
        }
    }
}
