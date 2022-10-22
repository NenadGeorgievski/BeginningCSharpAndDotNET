string[] names = { "Alonso", "Zheng", "Smsonianith", "Jones", "Smysthethe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

//Query syntax

var queryResults = from n in names where n.StartsWith("S") orderby n select n;

Console.WriteLine("Names starting with S ordered alphabetically: ");
foreach (var item in queryResults)
{
    Console.WriteLine(item);
}
Console.WriteLine();
//Method syntax

var queryResults1 = names.Where(n => n.StartsWith("S")).OrderBy(n => n.Length);

foreach (var item in queryResults1)
{
    Console.WriteLine(item);
}