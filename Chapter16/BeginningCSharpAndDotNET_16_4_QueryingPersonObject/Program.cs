using System.Net.Cache;
using BeginningCSharpAndDotNET_16_4_QueryingPersonObject;

List<Person> people = new List<Person>()
{
    new Person()  { FirstName = "Alonso", LastName = "MIkel", Age = 44 },
    new Person()  { FirstName = "Mik", LastName = "Kane", Age = 24 },
    new Person()  { FirstName = "Aloha", LastName = "Podence", Age = 14 },
    new Person()  { FirstName = "Aloo", LastName = "Neto", Age = 34 },
    new Person()  { FirstName = "Asto", LastName = "Van Persie", Age = 34 },
    new Person()  { FirstName = "Schumi", LastName = "Mkel", Age = 43 },
    new Person()  { FirstName = "Leto", LastName = "Henry", Age = 41 },
    new Person()  { FirstName = "Hans", LastName = "MIkel", Age = 42 },
    new Person()  { FirstName = "Lars", LastName = "Pires", Age = 21 },
    new Person()  { FirstName = "Mars", LastName = "Ljungberg", Age = 23 },
    new Person()  { FirstName = "Bars", LastName = "Nema", Age = 32 },
    new Person()  { FirstName = "Cars", LastName = "Whoknows", Age = 21 },
    new Person()  { FirstName = "Wars", LastName = "Forphan", Age = 20 },

};
//Query synthax
var queryResults = from p in people where p.LastName.StartsWith("F") select p;

foreach (var item in queryResults)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} with the ripe old age of: {item.Age} has a last name that starts with F.");
}
Console.WriteLine();
//Method synthax

var methodResults = people.Where(p => p.LastName.StartsWith("F"));
foreach (var item in methodResults)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} with the ripe old age of: {item.Age} has a last name that starts with F.");
}
Console.WriteLine();
var result = people.Where(p => p.Age >= 21);
foreach (var item in result)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} has an age higher or equals to 21.");
}