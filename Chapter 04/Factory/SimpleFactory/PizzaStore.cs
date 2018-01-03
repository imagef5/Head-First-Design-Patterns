
namespace SimpleFactory
{
    public  class PizzaStore 
    {
        SimplePizzaFactory pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            var pizza = pizzaFactory.CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}