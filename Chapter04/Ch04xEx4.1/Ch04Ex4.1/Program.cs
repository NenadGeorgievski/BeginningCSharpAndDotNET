int var1 = 51, var2 = 2;

if((var1 > 10) ^ (var2 > 10))
{
    Console.WriteLine("One of these numbers is greater than 10, but not both of them.");
} else
{
    Console.WriteLine("The condition is not matched.");
}

int num1, num2;

do
{
    Console.WriteLine("Please enter two numbers, one of them being greater than 10.");
    Console.WriteLine("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number ");
    num2 = Convert.ToInt32(Console.ReadLine());
} while (!((num1 > 10) ^ (num2 > 10)));

Console.WriteLine($"You have entered the correct format of numbers.");