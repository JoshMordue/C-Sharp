using System;
using System.IO;


namespace AdventofCode_2015_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"prompt.txt";
            string line;
            int counter = 0;

            using (StreamReader sentences = new StreamReader(path))
            {
                while ((line = sentences.ReadLine()) != null)
                {

                    if (CheckLine(line))
                    {
                        counter++;
                    }

                }
                Console.WriteLine(counter);

            }
        }

         static bool CheckLine(string line)
        {
            string[] illegalStrings = { "ab", "cd", "pq", "xy" };
            int vowelCount = 0;

            //checking for illegal strings

            foreach (var nonoword in illegalStrings)
            {
                if (line.Contains(nonoword))
                {
                    Console.WriteLine($"{nonoword}");
                    return false;
                }
            } 


            for (int i = 0; i < line.Length; i++)
            {         
                if (i > 0)
                {
                    if (line[i] == line[i - 1])
                    {
                        return false;
                    }
                }

                //checking for 3 vowels minimum
                if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u')
                {
                    vowelCount++;
                }
            }

            if (vowelCount > 2)
            {
                return true;
            }
            return false;
        }

    }

} 



