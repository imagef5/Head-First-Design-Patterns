using System;
using System.Collections;
using System.Collections.Generic;

namespace MenuIteratorAnother
{
    public class MenuItem : IMenuItem 
    {
        #region private fields
        string name;
        string description;
        double price;
        bool isVegetarian;
        #endregion

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.isVegetarian = isVegetarian;
        }

        #region Implement IMenuItem interface
        public string Name => name;
        public string Description => description;
        public double Price => price;
        public bool IsVegetarian => isVegetarian;

        public void Print()
        {
            Console.Write($"    {name}");
            if(isVegetarian)
                Console.Write($"(v)");
            Console.WriteLine($", {price}");
            Console.WriteLine($"        -- {description}");
        }
        #endregion

        #region Implement IEnumerable<IMenuComponent> interface
        public IEnumerator<IMenuComponent> GetEnumerator()
        {
            return new NullIterator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}