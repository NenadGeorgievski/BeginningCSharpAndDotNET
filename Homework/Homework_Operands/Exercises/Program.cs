Console.WriteLine("This program will output the sum of two numbers. Please enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of {num1} + {num2} = {num1 + num2}");

Console.WriteLine("This program will output the result after dividing two numbers. Please enter the first one:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now the second number:");
int num4 = Convert.ToInt32(Console.ReadLine());

double div1 = num3 / num4;

Console.WriteLine($"The result from dividing {num3} / {num4} = {div1}");

Console.WriteLine($"{-1 + 4*6}");
Console.WriteLine($"{(35 + 5) / 7}");
Console.WriteLine($"{14 + (-4)*6/11}");
Console.WriteLine($"{2 + 15/6*1 - (7%2)}");

Console.WriteLine("Now enter two numbers and they will switch places:");
Console.WriteLine("Enter first number:");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now the second number:");
int num6 = Convert.ToInt32(Console.ReadLine());
int swapNum5 = num6;
int swapNum6 = num5;
Console.WriteLine($"The numbers you entered were First Num:{num5}, Second Num:{num6}, and after swaping their places First Num: {swapNum5}, second Num: {swapNum6}");
Console.WriteLine("Now you will enter three numbers and see the result from their multiplication. Enter first num:");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second num:");
int num8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number:");
int num9 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num7} * {num8} * {num9} = {num7 * num8 * num9}");