using System.Collections;
using Ch11Ex05;

ArrayList list = new ArrayList();
list.Add(new Person("Rual", 30));
list.Add(new Person("Ben", 25));
list.Add(new Person("Jerry", 130));
list.Add(new Person("Tom", 31));
Console.WriteLine("Unsorted people");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{(list[i] as Person).Name} {(list[i] as Person).Age}");
}
Console.WriteLine();
Console.WriteLine($"People sorted with default comparer (by age):");
list.Sort();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{(list[i] as Person).Name} {(list[i] as Person).Age}");
}
Console.WriteLine();
Console.WriteLine("People sorted with non-default comparer (by name):");
list.Sort(PersonNameComparer.Default);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{(list[i] as Person).Name} {(list[i] as Person).Age}");
}
