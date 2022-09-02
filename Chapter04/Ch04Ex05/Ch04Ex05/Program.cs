double balance, interestRate, targetBalance;

Console.WriteLine("What is your current balance?");
balance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your current annual rate? (in %)");
interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
Console.WriteLine("What balance would you like to have?");
targetBalance = Convert.ToDouble(Console.ReadLine());
int totalYears = 0;

while(balance < targetBalance)
{
    balance *= interestRate;
    ++totalYears;
}

Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you will have a balance of {balance}.");
if(totalYears == 0)
{
    Console.WriteLine("To be honest, you didn't really have to use this calculator.");
}