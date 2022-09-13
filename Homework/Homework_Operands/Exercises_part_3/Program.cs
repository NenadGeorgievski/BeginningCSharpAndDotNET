Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You look older than {age}");

Console.WriteLine("Now enter a number and it will be displayed in various ways:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x} {x} {x} {x}");
Console.WriteLine("{0}{0}{0}{0}", x);
Console.WriteLine($"{x} {x} {x} {x}");
Console.WriteLine("{0}{0}{0}{0}", x);

Console.WriteLine("Enter a number:");
int rect = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{rect}{rect}{rect}");
Console.WriteLine($"{rect} {rect}");
Console.WriteLine($"{rect} {rect}");
Console.WriteLine($"{rect} {rect}");
Console.WriteLine($"{rect}{rect}{rect}");

Console.WriteLine("Enter the temperature in Celsius:");
double temp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{temp} to Kelvin = {temp + 273.15}");
Console.WriteLine($"{temp} to Fahreinheit = {(temp * 1.8) + 32}");