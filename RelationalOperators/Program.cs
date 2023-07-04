using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds = 31;
            int minutes = 1;

            if ((minutes < 59) && ((seconds + 1) > 59))
            {
                minutes++;
            }
        }
    }
}
