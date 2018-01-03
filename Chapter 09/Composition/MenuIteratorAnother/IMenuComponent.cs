using System.Collections.Generic;

namespace MenuIteratorAnother
{
    public interface IMenuComponent : IEnumerable<IMenuComponent>
    {
        string Name { get; }
        string Description { get; }

        void Print();
    }


    public interface IMenuComposit : IMenuComponent 
    {
        void Add(IMenuComponent component);
        void Remove(IMenuComponent component);
        IMenuComponent GetChild(int depth);
    }
    
    public interface IMenuItem : IMenuComponent
    {
        double Price { get; }
        bool IsVegetarian { get; }
    }
}