using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
    
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza}");
    
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza}");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine($"Ethan ordered a {pizza}");
    
            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza}");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine($"Ethan ordered a {pizza}");
    
            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine($"Joel ordered a {pizza}");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine($"Ethan ordered a {pizza}");
    
            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Joel ordered a {pizza}");
        }
    }
}
