using System;

namespace Objects
{
    public class Cow : Animal
    {
      
        public Cow() : base()
        {

        }

        public Cow(string name, int age) : base(name, age)
        {

        }
        public void SupplyMilk()
        {
            Console.WriteLine($"{Name} is lactating.");
        }

        public void Moo()
        {
            Console.WriteLine($"{Name} is mooing.");
        }

    }

}
