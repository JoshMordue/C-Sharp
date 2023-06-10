using System;
using System.Threading;

namespace TicTacToe
{
    internal class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;

        static int winner = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("TIC-TAC-TOE");
                Console.WriteLine("Player 1 is 'X', Player 2 is 'O'");
                Console.WriteLine("*****************************");
                Board();
            } while (winner == 0);
            {
                Board();
                Console.WriteLine("\n");
                Console.WriteLine($"Player: {player} turn!");
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("\n");

                choice = int.Parse(Console.ReadLine());


            }









        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[1]}  |  {arr[2]}  |  {arr[3]}  ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[4]}  |  {arr[5]}  |  {arr[6]}  ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[7]}  |  {arr[8]}  |  {arr[9]}  ");
            Console.WriteLine("     |     |      ");
        }



    }
}
