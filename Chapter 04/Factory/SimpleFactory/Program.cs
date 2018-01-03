using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            IPizza pizza = store.OrderPizza("cheese");
            Console.WriteLine($"We ordered a {pizza.Name}");
            //Console.WriteLine(pizza);
            Console.WriteLine("-------------------------");
            pizza = store.OrderPizza("veggie");
            Console.WriteLine($"We ordered a {pizza.Name}");
            //Console.WriteLine(pizza);
        }
    }
}
