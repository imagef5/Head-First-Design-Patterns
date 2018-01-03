using System;

namespace StaticInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            singleton1.SomeValue++;
            Console.WriteLine($"singleton1.value : {singleton1.SomeValue}");
            Console.WriteLine($"singleton2.value : {singleton2.SomeValue}");

            Console.WriteLine("-------------------");

            singleton2.SomeValue++;
            Console.WriteLine($"singleton1.value : {singleton1.SomeValue}");
            Console.WriteLine($"singleton2.value : {singleton2.SomeValue}");
        }
    }
}
