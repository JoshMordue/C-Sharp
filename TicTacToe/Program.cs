using System;
using System.Threading;

namespace TicTacToe
{
    internal class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //player 1 is X, player 2 is O
        static int choice;
        static int winner = 0;

        static void Main(string[] args)
        {
            while (winner == 0)
            {
                Board();
                Console.WriteLine("\n");
                Console.WriteLine($"Player {player}'s turn!");
                Console.WriteLine("Please enter your choice");
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player == 1)
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'O';
                        player--;
                    }
                }
                else
                {
                    Console.Write($"Unfortunately space {choice} has already been taken.");
                    Console.WriteLine("\n");
                    Console.Write("Please ensure you pick a spot that's available.");
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                winner = CheckWin();

                if (winner == 1 || winner == -1)
                {
                    if (winner == 1)
                    {
                        Console.WriteLine($"Player {player} wins!");
                    }
                    else
                    {
                        Console.WriteLine("The game outcome is a draw.");
                    }

                    Console.WriteLine($"Did you want to play again? Enter 1 to Continue 0 to Quit.");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                        int player = 1; //player 1 is X, player 2 is O
                        int choice = 0;
                        int winner = 0;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }

                Console.Clear();
                Console.WriteLine(arr[choice]);
            }

        }


        private static void Board()
        {
            Console.WriteLine("TIC-TAC-TOE");
            Console.WriteLine("*****************************");
            Console.WriteLine("Player 1 is 'X', Player 2 is 'O'");

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

        private static int CheckWin()
        {
            //Checking the horizontal win conditions
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if(arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }

            else if(arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }

            //checking verticle win conditions
            else if(arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }

            else if(arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }

            else if(arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }

            //checking diagonal win conditions
            else if(arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            return 0;
        }
    }
}
