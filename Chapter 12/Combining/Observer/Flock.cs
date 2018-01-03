using System.Collections.Generic;

namespace Observer
{
    public class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }
        public void Quack()
        {
            foreach(var quacker in quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer) 
        {
            foreach(var quacker in quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
    
        public void NotifyObservers() { }
    }
}