using System;

namespace Menu
{
    public class MenuItem : IMenuComponent
    {
        string name;
        string description;
        double price;
        bool isVegetarian;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.isVegetarian = isVegetarian;
        }

        public string Name => name;
        public string Description => description;
        public double Price => price;
        public bool IsVegetarian => isVegetarian;

        public void Add(IMenuComponent component) => throw new NotSupportedException();

        public void Remove(IMenuComponent component) => throw new NotSupportedException();

        public IMenuComponent GetChild(int depth) => throw new NotSupportedException();

        public void Print()
        {
            Console.Write($"    {name}");
            if(isVegetarian)
                Console.Write($"(v)");
            Console.WriteLine($", {price}");
            Console.WriteLine($"        -- {description}");
        }
    }
}