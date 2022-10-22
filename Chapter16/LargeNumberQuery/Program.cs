int[] numbers = GenerateLotsOfNumbers(12045678);

int[] GenerateLotsOfNumbers(int length)
{
    Random random = new Random();
    int[] numbers = new int[length];

    for (int i = 0; i < length; i++)
    {
        numbers[i] = random.Next(0, length);
    }
    return numbers;
}

var queryResult = from n in numbers where n < 1000 orderby n select n;

Console.WriteLine("Number from our array that are smaller than 1000 ordered by size:");

foreach (var item in queryResult)
{
    Console.WriteLine(item);
}