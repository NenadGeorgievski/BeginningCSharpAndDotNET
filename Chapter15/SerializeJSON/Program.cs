using System.Text.Json;
using SerializeJSON;

List<Book> books = new List<Book>();
Book book1 = new Book
{
    title = "Beginning C# and .NET",
    author = "Benjamin Parkins and Jon Reid",
    code = "911-221-223-223"
};

Book book2 = new Book
{
    title = "C Sharp",
    author = "John Reid",
    code = "223-305"
};

Book book3 = new Book
{
    title = "C Sharp Fundamentals",
    author = "John Reid and friends",
    code = "223-305-3323"
};

books.Add(book1);
books.Add(book2);
books.Add(book3);

string jsonString1 = JsonSerializer.Serialize(books, typeof(List<Book>));
File.WriteAllText("Books.json", jsonString1);

string jsonString2 = File.ReadAllText("Books.json");
List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);

foreach (Book b in books2)
{
    Console.WriteLine("code: {0} title: {1} author: {2}", b.code, b.title, b.author);
}

string jsonWeatherString = File.ReadAllText("../../../Weather.json");
Weather weather = JsonSerializer.Deserialize<Weather>(jsonWeatherString);

Console.WriteLine($"{nameof(weather.Date)} : {weather.Date.ToString()}");
Console.WriteLine($"The temperature is: {weather.TemperatureCelsius}");
Console.WriteLine($"So basically, it's {weather.Summary} outside.");
Console.WriteLine("Dates available are: ");
foreach (DateTime date in weather.DatesAvailable)
{
    if(weather.DatesAvailable.Last() == date)
    {
        Console.Write(date.ToString());
    } else
    {
        Console.Write(date.ToString() + ", ");
    }
    
}
Console.WriteLine();
Console.WriteLine($"The temperature ranges are: ");
TemperatureRanges tempRanges = new TemperatureRanges();
Ranges ranges = new Ranges();
Console.WriteLine($"\t Cold - {nameof(weather.TemperatureRanges.Cold.High)} : {weather.TemperatureRanges.Cold.High}");
Console.WriteLine($"\t Cold - {nameof(weather.TemperatureRanges.Cold.Low)} : {weather.TemperatureRanges.Cold.Low}");
Console.WriteLine($"\t Hot - {nameof(weather.TemperatureRanges.Hot.High)} : {weather.TemperatureRanges.Hot.High}");
Console.WriteLine($"\t Hot - {nameof(weather.TemperatureRanges.Hot.Low)} : {weather.TemperatureRanges.Hot.Low}");
Console.WriteLine(tempRanges.Cold);
Console.WriteLine("The weather in brief is: ");
foreach(string word in weather.SummaryWords)
{
    if(weather.SummaryWords.Last() == word)
    {
        Console.Write(word);
    } else
    {
        Console.Write(word + ", ");
    }
    
}

