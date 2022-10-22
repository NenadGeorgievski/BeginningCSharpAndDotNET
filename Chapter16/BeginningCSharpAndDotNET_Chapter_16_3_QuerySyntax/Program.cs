string[] names = { "Alonso", "Mikka", "Mihael", "Rubens", "Giancarlo", "Max", "Hamilton", "Henry", "Pires", "Ljungberg", "Vieira", "Campbell" };
var queryResult = from n in names where n.StartsWith("M") select n;
Console.WriteLine("Names of famous F1 drivers starting with M: ");
foreach(var item in queryResult)
{
    Console.WriteLine(item);
}