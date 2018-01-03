using System.Collections.Generic;

namespace Menu
{
    public interface IMenuComponent
    {
        string Name { get; }
        string Description { get; }
        double Price { get; }
        bool IsVegetarian { get; }

        void Add(IMenuComponent component);
        void Remove(IMenuComponent component);
        IMenuComponent GetChild(int depth);
        void Print();
    }
}