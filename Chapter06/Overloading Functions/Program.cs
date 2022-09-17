using System;

namespace Overloading_Functions
{
    internal class Program
    {
        static int showDouble(int val)
        {
            Console.WriteLine($"Doubled val: {val * 2}");
            return val * 2;
        }

        static void showDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"Doubled val: {val}");
        }
        static int showDouble(string val)
        {
            int res = Convert.ToInt32(val) * 2;
            Console.WriteLine($"Doubled val: {res}");
            return res;
        }

        static void showDouble(int val, out int doubled)
        {
            doubled = val * 2;
            Console.WriteLine($"Doubled val: {doubled}");
        }
        static void Main(string[] args)
        {
            int res1 = showDouble(5);
            int res2 = showDouble("5");
            int res3 = 5;
            showDouble(ref res3);
            showDouble(5, out int res4)
;            Console.ReadLine();
        }
    }
}
