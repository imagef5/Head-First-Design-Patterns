using System;
using System.Collections.Generic;

namespace Menu
{
    public class Menu : IMenuComponent
    {
        List<IMenuComponent> menuComponent = new List<IMenuComponent>();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Name => name;

        public string Description => description;

        public double Price => throw new NotSupportedException();

        public bool IsVegetarian => throw new NotSupportedException();

        public void Add(IMenuComponent component)
        {
            menuComponent.Add(component);
        }

        public void Remove(IMenuComponent component)
        {
            menuComponent.Remove(component);
        }

        public IMenuComponent GetChild(int depth)
        {
            return menuComponent[depth];
        }

        public void Print()
        {
            Console.WriteLine($"\n{name}, {description}");
            Console.WriteLine("---------------------------");

            foreach(var menuitem in menuComponent)
            {
                menuitem.Print();
            }
        }  
    }
}