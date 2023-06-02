using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        string inputText;
        bool isPalindrome;


        public void Main(string[] args, bool isPalindrome)
        {
            System.Console.WriteLine("****************");
            Console.WriteLine("Please enter a word/Sentence and we see if it is a palindrome");
            while (true) {
                inputText = Console.ReadLine();
                if (inputText != null || Regex.IsMatch(inputText, @"^[a-zA-Z]+$ "));
                {
                    inputCheck(inputText);
                }
                
            }
        }
        public string inputCheck(string Text)
        {
            Text = Text.Trim(' ');
            Console.WriteLine(Text);
        }

    }
}
