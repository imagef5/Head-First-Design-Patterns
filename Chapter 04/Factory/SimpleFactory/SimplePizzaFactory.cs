
namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            
            switch(pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}