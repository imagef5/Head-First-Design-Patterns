using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough { get; set; }
        protected ISauce Sauce { get; set; }
        protected List<IVeggie> Veggies { get; set; }
        protected ICheese Cheese { get; set; }
        protected IPepperoni Pepperoni { get; set; }
        protected IClams Clam { get; set; }

        public abstract void Prepare();
        public virtual void Bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine($"Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"---- {Name} ----");
            if (Dough != null) {
                result.AppendLine(Dough.Description());
            }
            if (Sauce != null) {
                result.AppendLine(Sauce.Description());
            }
            if (Cheese != null) {
                result.AppendLine(Cheese.Description());
            }
            if (Veggies != null) {
                result.AppendLine("Veggies : ");
                foreach(var veggie in Veggies)
                {
                    result.AppendLine(veggie.Description().PadLeft(40));
                }
            }
            if (Clam != null) {
                result.AppendLine(Clam.Description());
            }
            if (Pepperoni != null) {
                result.AppendLine(Pepperoni.Description());
            }
            return result.ToString();
        }
    }
}