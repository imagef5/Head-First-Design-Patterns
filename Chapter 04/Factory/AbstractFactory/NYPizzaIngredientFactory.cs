
using System.Collections.Generic;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<IVeggie> CreateVeggies()
        {
            List<IVeggie> veggies = new List<IVeggie>();
            veggies.Add(new Garlic());
            veggies.Add(new Onion());
            veggies.Add(new Mushroom());
            veggies.Add(new RedPepper());

            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }
    }
}