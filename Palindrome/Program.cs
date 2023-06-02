using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class PalindromeChecker
    {
        static void Main(string[] args)
        {
            string inputText;
            bool isPalindrome;

            System.Console.WriteLine("****************");
            Console.WriteLine("Please enter a word/Sentence and we see if it is a palindrome.");
            Console.WriteLine("Please note when comparing a sentence spaces will not be considered.");
            while (true) {
                inputText = Console.ReadLine();
                if (inputText != null || Regex.IsMatch(inputText, @"^[a-zA-Z]+$ "));
                {
                    Console.WriteLine($"{inputText} was entered.");
                    InputCheck(inputText);
                }

            }
        }

        public string InputCheck(string Text) 
        { 
            Text = Text.Trim(' ');
            Console.WriteLine(Text);
            return Text;
        }
    }
}
