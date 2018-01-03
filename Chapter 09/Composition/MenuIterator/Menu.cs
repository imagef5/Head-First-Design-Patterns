using System;
using System.Collections;
using System.Collections.Generic;

namespace MenuIterator
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

            foreach(var item in menuComponent)
            {
                item.Print();
            }
        }

        #region Implement IEnumerable<IMenuComponent> interface
        public IEnumerator<IMenuComponent> GetEnumerator()
        {
            foreach(var memu in menuComponent)
            {
                yield return memu;
                var composite = memu as IMenuComponent;
                if (composite != null) {
                    foreach (var sub in composite) {
                        yield return sub;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}