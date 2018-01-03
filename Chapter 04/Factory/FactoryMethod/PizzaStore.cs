
namespace FactoryMethod
{
    public abstract class PizzaStore 
    {

        public Pizza OrderPizza(string item)
        {
            var pizza = CreatePizza(item);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string item);
    }
}