using System;

namespace AbstractFactory
{
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
            Pepperoni = pizzaIngredientFactory.CreatePepperoni();
        }
    }
}