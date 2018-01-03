using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings { get; set; } = new List<string>();
        
        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in Toppings)
            {
                Console.WriteLine($"{topping.PadLeft(40)}");
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }
        public virtual void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }
        public virtual void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }
    }
}