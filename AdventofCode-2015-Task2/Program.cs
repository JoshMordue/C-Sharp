using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode_2015_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"prompt.txt";
            int total = 0;
            string height = 0;
            string width = 0;
            string length = 0;

            var file = File.ReadLines(path);

            Console.WriteLine(file);

            //length l, width w, and height  2*l*w + 2*w*h + 2*h*l.
            //foreach (string line in file)
            //{
            //    string[] s = sData.Split('|');
            //    //Console.WriteLine(results);
            //    Console.WriteLine(results[0]);
            //        //Console.WriteLine(results[1]);
            //        //Console.WriteLine(results[2]);


            //        length = results[0];
            //        width = results[1];
            //        height = results[2];
            //        //Console.WriteLine(length + width + height);

            //    }

                







            

        }
    }
}
