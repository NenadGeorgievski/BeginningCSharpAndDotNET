Console.WriteLine("Please enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} x {num2} x {num3} = {num1 * num2 * num3}");

Console.WriteLine("Please enter two numbers. First one:");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second one:");
int num5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num4} + {num5} = {num4 + num5}");
Console.WriteLine($"{num4} - {num5} = {num4 - num5}");
Console.WriteLine($"{num4} * {num5} = {num4 * num5}");
Console.WriteLine($"{num4} / {num5} = {num4 / num5}");
Console.WriteLine($"{num4} % {num5} = {num4 % num5}");

Console.WriteLine("Enter a number to see it's multiplication table:");
int num6 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num6} x {i} = {num6 * i}");
}

Console.WriteLine("Now enter four numbers and I will show you their average:");
Console.WriteLine("First Number:");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second Number:");
int num8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Third Number:");
int num9 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Fourth Number:");
int num10 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The average of these four numbers, {num7} + {num8} + {num9} + {num10} is {(num7 + num8 + num9 + num10)/4}");
Console.WriteLine("Now enter three numbers, one by one;");
int num11 = Convert.ToInt32(Console.ReadLine());
int num12 = Convert.ToInt32(Console.ReadLine());
int num13 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"({num11} + {num12}) * {num13} = {(num11 + num12 ) * num13} ");
Console.WriteLine($"({num11} * {num12}) + ({num12} * {num13}) = {(num11 * num12) + (num12 * num13)} ");

