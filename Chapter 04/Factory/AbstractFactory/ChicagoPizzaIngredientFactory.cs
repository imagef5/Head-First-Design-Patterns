
using System.Collections.Generic;

namespace AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<IVeggie> CreateVeggies()
        {
            List<IVeggie> veggies = new List<IVeggie>();
            veggies.Add(new BlackOlives());
            veggies.Add(new Spinach());
            veggies.Add(new EggPlant());
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClam();
        }
    }
}