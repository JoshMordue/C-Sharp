﻿using System;
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

            while (winner == 0) {
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

                Console.Clear();

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



    }
}