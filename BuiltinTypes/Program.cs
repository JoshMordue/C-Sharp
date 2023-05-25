using System;


namespace BuiltinTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Byte: minimum {byte.MinValue}, maximum {byte.MaxValue}");
            //Console.WriteLine($"sByte: minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
            //Console.WriteLine($"short: minimum {short.MinValue}, maximum {short.MaxValue}");

            var x = 234;
            Console.WriteLine(x.GetType());

            Console.WriteLine($"int minimum value: {int.MinValue}, maximum value {int.MaxValue}"); 
            Console.WriteLine($"long minimum value: {long.MinValue}, maximum value {long.MaxValue}"); 

            Console.WriteLine();
            Console.WriteLine($"float minimum value: {float.MinValue}, maximum value {float.MaxValue}");
            Console.WriteLine($"double minimum value: {double.MinValue}, maximum value {double.MaxValue}");

            Console.WriteLine();

            float f = 123.456789012345678f;
            double d = 123.456789012345678;

            Console.WriteLine($"f is {f:f99}");
            Console.WriteLine($"d is {d:f99}");

            var y = 123.4;
            Console.WriteLine(y.GetType());

            decimal z = 123.4567890123456789012345678901234567890123456789m;
            Console.WriteLine();
            Console.WriteLine($"decimal minimum value: {decimal.MinValue}, maximum value {decimal.MaxValue}");
            Console.WriteLine($"z is {z:F99}");
        }
    }
}
