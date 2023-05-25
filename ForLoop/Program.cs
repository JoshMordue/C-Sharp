using System;


namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++) 
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j <= 9; j++)

                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }             
        }
    }
}
4