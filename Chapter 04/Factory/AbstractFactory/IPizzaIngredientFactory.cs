using System.Collections.Generic;

namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggie> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}