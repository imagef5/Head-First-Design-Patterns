using System;
using System.Collections;
using System.Collections.Generic;

namespace MenuIteratorAnother
{
    public class Menu : IMenuComposit
    {
        #region private fields
        List<IMenuComponent> menuComponent = new List<IMenuComponent>();
        string name;
        string description;
        #endregion

        #region Constructor
        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        #endregion

        #region Implement IMenuComposit interface
        public string Name => name;

        public string Description => description;

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
        #endregion 

        #region Implement IEnumerable<IMenuComponent> interface
        public IEnumerator<IMenuComponent> GetEnumerator()
        {
            foreach(var memu in menuComponent)
            {
                yield return memu;
                var composite = memu as IMenuComposit;
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