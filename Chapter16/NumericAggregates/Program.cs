int[] numbers = GenerateLotsOfNumbers(12345678);

int[] GenerateLotsOfNumbers(int length)
{
    Random generator = new Random(0);   
    int[] numbers = new int[length];

    for (int i = 0; i < length; i++)
    {
        numbers[i] = generator.Next();
    }
    return numbers;
}

var queryResults = from n in numbers where n > 1000 select n;

Console.WriteLine("Count of numbers > 1000:");
Console.WriteLine(queryResults.Count());
Console.WriteLine("Max of numbers > 1000:");
Console.WriteLine(queryResults.Max());
Console.WriteLine("Min of numbers > 1000:");
Console.WriteLine(queryResults.Min());
Console.WriteLine("Average of numbers > 1000:");
Console.WriteLine(queryResults.Average());
Console.WriteLine("Sum of numbers > 1000:");
Console.WriteLine(queryResults.Sum(n => (long) n));