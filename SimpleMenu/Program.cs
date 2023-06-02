using System;

namespace SimpleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Mocha");
            Console.WriteLine("4 - Americano");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q - Quit the Program");

            //while (!(userChoice.Equals('q') || userChoice.Equals('Q')))
            do
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose: " +  userChoice);
                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("Making a Cappucino.");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make Espresso");
                        Console.WriteLine("Add the milk to the espresso.");
                        break;
                    case '2':
                        Console.WriteLine("Latte");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make Espresso");
                        Console.WriteLine("Add the milk to the espresso.");
                        break;
                    case '3':
                        Console.WriteLine("Mocha");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make Espresso");
                        Console.WriteLine("Add the milk to the espresso.");
                        break;
                    case '4':
                        Console.WriteLine("Americano");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make Espresso");
                        Console.WriteLine("Add the milk to the espresso.");
                        break;
                    case '5':
                        Console.WriteLine("Macchiato");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make Espresso");
                        Console.WriteLine("Add the milk to the espresso.");
                        break;
                    default:
                        Console.WriteLine("Returning Coins");
                        break;

                }
            } while (!userChoice.Equals('q'));

            //var x = userChoice.Key;
            //char y = userChoice.KeyChar;
            //var z = userChoice.Modifiers;

            //Console.WriteLine("Key : " + x);
            //Console.WriteLine("Key char : " + y);
            //Console.WriteLine("modifiers: : " + z);
        }
    }
}
