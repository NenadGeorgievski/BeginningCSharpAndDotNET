using JoinQuery;

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
    new Customer {ID = "P", City = "Boston", Country = "USA", Region = "North America", Sales = 1229},
    new Customer {ID = "Q", City = "Liverpool", Country = "England", Region = "North Europe", Sales = 3234},
    new Customer {ID = "R", City = "London", Country = "England", Region = "North Europe", Sales = 9999},
    new Customer {ID = "S", City = "Skopje", Country = "Macedonia", Region = "Europe", Sales = 124},
};

List<Order> orders = new List<Order>
{
    new Order {ID = "P", Ammount = 100},
    new Order {ID = "Q", Ammount = 200},
    new Order {ID = "R", Ammount = 300},
    new Order {ID = "S", Ammount = 400},
    new Order {ID = "T", Ammount = 500},
    new Order {ID = "U", Ammount = 600},
    new Order {ID = "V", Ammount = 700},
    new Order {ID = "W", Ammount = 800},
    new Order {ID = "X", Ammount = 900},
    new Order {ID = "Y", Ammount = 1000},
    new Order {ID = "P", Ammount = 1100},
};

var queryResults = from c in customers
                   join o in orders on c.ID equals o.ID
                   select new
                   {
                       c.ID,
                       c.City,
                       SalesBefore = c.Sales,
                       NewOrder = o.Ammount,
                       SalesAfter = c.Sales + o.Ammount
                   };

foreach (var item in queryResults)
{
    Console.WriteLine(item);
}