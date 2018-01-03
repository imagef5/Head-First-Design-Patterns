using System;

namespace AbstractFactory
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Veggies = pizzaIngredientFactory.CreateVeggies();
        }
    }
}