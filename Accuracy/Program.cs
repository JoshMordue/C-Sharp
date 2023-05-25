using System;


namespace Accuracy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double result1 = 0.1 * 8;
            double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
            Console.WriteLine();
            Console.WriteLine($"first result is: {result1}");
            Console.WriteLine($"second result is: {result2}");

            double difference = result1 - result2;
            Console.WriteLine($"the difference is {difference}");

        }
    }
}
