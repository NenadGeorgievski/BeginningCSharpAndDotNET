using System;

namespace Ch09Ex03
{
    class MyClass
    {
        public int val;
    }

    struct MyStruct
    {
        public int val;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass objA = new MyClass();
            MyClass objB = objA;
            objA.val = 10;
            objB.val = 20;
            MyStruct structA = new MyStruct();
            MyStruct structB = structA;
            structA.val = 30;
            structB.val = 40;
            Console.WriteLine($"objA.val = {objA.val}");
            Console.WriteLine($"objB.val = {objB.val}");
            Console.WriteLine($"structA.val = {structA.val}");
            Console.WriteLine($"structB.val = {structB.val}");
        }
    }
}
