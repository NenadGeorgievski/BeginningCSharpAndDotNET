using System;
using System.Reflection.Metadata.Ecma335;

namespace Ch06Ex03
{
    internal class Program
    {
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
            
        }
        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine($"The sum of all the values is: {sum}");

            int[] myArray = { 1, 8, 2, 3, 5, 3, 4, 6, 4, 6, 3, 5 };
            Console.WriteLine($"The maximum value in myArray is: {MaxValue(myArray, out int maxIndex)}");
            Console.WriteLine($"The first occurence of this value is at {maxIndex + 1}");

            static int MaxValue(int[] intArray, out int MaxIndex)
            {
                int maxValue = intArray[0];
                MaxIndex = 0;
                for (int i = 1; i < intArray.Length; i++)
                {
                    if (intArray[i] > maxValue)
                    {
                        maxValue = intArray[i];
                        MaxIndex = i;
                    }
                   
                }
                return maxValue;
            }
        }
    }
}
