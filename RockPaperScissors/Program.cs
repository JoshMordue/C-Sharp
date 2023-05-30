using System;

namespace RockPaperScissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;
        bool playAgain = true;
        static void Main(string[] args)
        {

            Random randomNumbers = new Random();

            string playerChoice;
            int playerValue = -1;

            do
            {
                string computerChoice;
                int computerValue = randomNumbers.Next(3);



                Console.Clear();
                Console.Write("Please enter rock, paper or scissors ");
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice.Equals("rock"))
                {
                    playerValue = Rock;
                }

                else if (playerChoice.Equals("paper"))
                {
                    playerValue = Paper;
                }

                else if (playerChoice.Equals("scissors"))
                {
                    playerValue = Scissors;
                }
                else
                {
                    Console.WriteLine($"{playerChoice} is not a valid choice");
                }

                if (computerValue == 0)
                {
                    computerChoice = "Rock";
                }
                else if (computerValue == 1)
                {
                    computerChoice = "Paper";
                }
                else
                {
                    computerChoice = "Scissors";
                }


                Console.WriteLine($"Computer choice: {computerChoice}, player choice {playerChoice}");

                if (playerValue == computerValue)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if ((playerValue - 1 == computerValue)
                    || (playerValue == Rock && computerValue == Scissors))
                {
                    Console.WriteLine("Player Wins!");
                }
                else
                {
                    Console.WriteLine("The Computer wins!");
                }

                Console.WriteLine($"player chose {playerChoice}, the value is {playerValue}");

            } while (GetYesOrNo("Would you like to play again"));
             
        }
    
        /**
        * Returns a boolean response to a yes/no question.
        *
        * @param string
        *            The question to be asked.
        * @return True if the answer was yes, False if no.
        */
        public static bool GetYesOrNo(string question)
        {
            char answer;
            while (true)  // infinite loop.  return will exit the method, thus terminating the loop
            {
                Console.Write($"{question} ");
                answer = Console.ReadKey(true).KeyChar;
                answer = char.ToLower(answer);
                if (answer.Equals('y'))
                    return true;
                if (answer.Equals('n'))
                    return false;
            }
        }
}
}