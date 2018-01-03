using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    public interface IPizza
    {
        string Name { get; }
        // string Dough { get; set; }
        // string Sauce { get; set; }
        // List<string> Toppings { get; set; }

        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
    public abstract class Pizza : IPizza
    {
        public string Name { get; protected set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        
        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in Toppings)
            {
                Console.WriteLine($"{topping.PadLeft(20)}");
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