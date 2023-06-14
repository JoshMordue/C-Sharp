﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

                    if (CheckLine(line) == true) {
                        
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
            if (illegalStrings.All(line.Contains))
            {
                return false;
            }

            for (int i = 0; i < line.Length - 1; i++)
            {
                    //check for duplicate letters
                    if (line[i] == line[i + 1])
                    {
                        return false;

                    }
                
                //checking for 3 vowels minimum
                else if (vowelCount < 3)
                {
                    if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u')
                    {
                        vowelCount++;
                        Console.WriteLine("test3");

                        if (vowelCount > 10)
                        {
                            Console.WriteLine("test4");
                            return true;
                        }
                    }

                }
            }
                return false;
            }

        }
    }
}

