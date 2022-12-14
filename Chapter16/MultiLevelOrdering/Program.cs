using MultiLevelOrdering;

List<Customer> customers = new List<Customer>
{
    new Customer {ID = "A", City = "New York", Country = "USA", Region = "North America", Sales = 9999},
    new Customer {ID = "B", City = "Old York", Country = "Asia", Region = "Asia", Sales = 1909},
    new Customer {ID = "C", City = "New Hampshire", Country = "USA", Region = "North America", Sales = 2000},
    new Customer {ID = "D", City = "New Jork", Country = "USA", Region = "South Pole", Sales = 3000},
    new Customer {ID = "E", City = "Chicago", Country = "South Pole", Region = "North America", Sales = 9999},
    new Customer {ID = "F", City = "Orlando", Country = "USA", Region = "North America", Sales = 5000},
    new Customer {ID = "G", City = "Massachussets", Country = "USA", Region = "North America", Sales = 5454},
    new Customer {ID = "H", City = "Kentucky", Country = "USA", Region = "North America", Sales = 10200},
    new Customer {ID = "I", City = "Oklahoma", Country = "USA", Region = "North America", Sales = 99929},
    new Customer {ID = "J", City = "Iowa", Country = "USA", Region = "North America", Sales = 9944},
    new Customer {ID = "K", City = "Nantucket", Country = "USA", Region = "North America", Sales = 1500},
    new Customer {ID = "L", City = "Boston", Country = "USA", Region = "North America", Sales = 1229},
    new Customer {ID = "M", City = "Liverpool", Country = "England", Region = "North Europe", Sales = 3234},
    new Customer {ID = "N", City = "London", Country = "England", Region = "North Europe", Sales = 9999},
    new Customer {ID = "O", City = "Skopje", Country = "Macedonia", Region = "Europe", Sales = 124},
};

var queryResults = from c in customers 
                   orderby c.Region, c.Country, c.City
                   select new {c.ID, c.Region, c.Country, c.City};

foreach (var item in queryResults)
{
    Console.WriteLine(item);
}

var queryResult2 = from c in customers
                   group c by c.Region into cg
                   select new { TotalSales = cg.Sum(c => c.Sales), Region = cg.Key };

var orderedResults = from cg in queryResult2
                     orderby cg.TotalSales descending
                     select cg;

Console.WriteLine("Total\t: By\nSales\t: Region\n-----\t------");
foreach (var item in orderedResults)
{
    Console.WriteLine($"{item.TotalSales}\t: {item.Region}");
}