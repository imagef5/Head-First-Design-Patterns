using System;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();
            //Console.WriteLine();

            Console.WriteLine("\nMaking Coffee...");
            coffee.PrepareRecipe();

            TeaWiwhHook teaWiwhHook = new TeaWiwhHook();
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\n차 준비중....");
            teaWiwhHook.PrepareReceipe();

            Console.WriteLine("\n커피 준비중....");
            coffeeWithHook.PrepareReceipe();
        }
    }
}
