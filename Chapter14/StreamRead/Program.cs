using System;
using static System.Console;
using System.IO;


namespace StreamRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                using (FileStream aFile = new FileStream("Log.txt", FileMode.Open))
                {
                    using (StreamReader sw = new StreamReader(aFile))
                    {
                        line = sw.ReadLine();
                        //Read data in line by line
                        while (line != null)
                        {
                            WriteLine(line);
                            line = sw.ReadLine();
                        }
                    }
                }
            }
            catch (IOException e)
            {
                WriteLine("An IO Exception has been thrown.");
                WriteLine(e.ToString());
                return;
            }
        }
    }
}
