string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
var queryResults = names.Where(n => n.StartsWith("S"));
Console.WriteLine("Names beginning with S");
foreach (var item in queryResults)
{
    Console.WriteLine(item);
}

