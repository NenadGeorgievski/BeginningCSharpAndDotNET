using System;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Marko D Great", 12);
            chicken.Age += 1;

            chicken.Breed();
            chicken.Cluck();
            Console.WriteLine($"{chicken.Age} is the age of {chicken.Name}.");

            Chicken chicken1 = new Chicken();
            chicken1.Name = "Goran d Small";
            chicken1.Age = 1;

            chicken1.Cluck();
            chicken1.EatFood();

            Cow cow = new Cow("Milka", 12);

            cow.EatFood();
            cow.Moo();

            Animal newChicken = new Chicken("Iva",3);
            newChicken.EatFood();

            IAnimal newChickenInt = new Chicken(); ;
            newChicken.Name = "Dina";
            newChicken.Age = 1;

            newChickenInt.EatFood();

        }
    }

}
