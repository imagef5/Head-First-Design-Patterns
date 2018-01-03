
using System;

namespace AbstractFactory
{
    public abstract class PizzaStore 
    {

        public Pizza OrderPizza(string item)
        {
            var pizza = CreatePizza(item);

            Console.WriteLine($"--- Making a {pizza.Name} ---");
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string item);
    }
}