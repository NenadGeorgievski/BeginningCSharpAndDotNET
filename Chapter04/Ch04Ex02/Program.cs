using System;

namespace Ch04Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = default, var2 = default;
            try
            {
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                var2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} says {ex.Message} \r\n {ex.StackTrace}");
            }
           
            if(var1 < var2)
            {
                comparison = "Less than";
            } else
            {
                if(var1 == var2)
                {
                    comparison = "Equal to";
                } else
                {
                    comparison = "Greater than";
                }
            }
            Console.WriteLine($"The first number is {comparison}" + $" the second number.");
        }
    }
}
