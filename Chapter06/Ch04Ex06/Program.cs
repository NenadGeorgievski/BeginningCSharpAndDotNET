using System;

namespace Ch04Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command line args were specified.");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();  
        }
    }
}
