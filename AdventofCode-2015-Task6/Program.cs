using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace AdventofCode_2015_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"prompt.txt";
            string line;

            using (StreamReader sentences = new StreamReader(path))
            {
                while ((line = sentences.ReadLine()) != null)
                {




                    var pattern = @"(turn on|toggle|turn off)\ (\d+)\,(\d+)\ through\ (\d+)\,(\d+)";

                    var instructionsFlattened = line
                        .Select(i => Regex.Match(i, pattern).Groups)
                        .Select(g => new
                        {
                            Action = g[1].Value,
                            From = new
                            {
                                X = int.Parse(g[2].Value),
                                Y = int.Parse(g[3].Value)
                            },
                            To = new
                            {
                                X = int.Parse(g[4].Value),
                                Y = int.Parse(g[5].Value)
                            }
                        })
                        .SelectMany(i =>
                            from x in Enumerable.Range(i.From.X, 1 + i.To.X - i.From.X)
                            from y in Enumerable.Range(i.From.Y, 1 + i.To.Y - i.From.Y)
                            select new { i.Action, x, y });

                }



            }

            }

        }

        static string stripLine(string line)
        {
            foreach (char c in line)
            {
                string op = new String(line.TakeWhile(c => !Char.IsDigit(c)).ToArray()).Trim();
                string[] coords = line.Split(' ').Where(s => Char.IsDigit(s[0])).ToArray();
                Point p1 = Convert(coords[0]);
                Point p2 = Convert(coords[1]);
            }

            return line;


        }
    }
}
