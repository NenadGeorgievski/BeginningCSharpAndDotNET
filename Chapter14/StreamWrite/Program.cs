using System;
using System.IO;
using System.Linq.Expressions;

namespace StreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(aFile))
                    {
                        bool truth = true;
                        //Write data to file
                        sw.WriteLine("Hello to you.");
                        sw.Write($"It is now {DateTime.Now.ToLongDateString()} ");
                        sw.Write("And things are looking good.");
                        sw.Write("More than that.");
                        sw.Write($" It's {truth} that c# is fun.");

                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An IOException has been thrown.");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }






        }
    }
}
