using System;

namespace ExchangingData
{
    internal class Program
    {
        static int val;
        static void showDouble()
        {
            val *= 2;
            Console.WriteLine($"Val doubled = {val}");
        }
        static void Main(string[] args)
        {
            val = 5;
            Console.WriteLine($"val = {val}");
            showDouble();
            Console.WriteLine($"val = {val}");
            

            CustomerName myCustomer;
            myCustomer.firstName = "Nenad";
            myCustomer.lastName = "Georgievski";
            Console.WriteLine($"{myCustomer.firstName} {myCustomer.lastName}");
            Console.WriteLine($"{myCustomer.fullName}");
        }
            struct CustomerName
        {
            public string firstName, lastName;
            public string fullName => $"{firstName} {lastName}";
        }
        
    }
}
