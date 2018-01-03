using System.Collections.Generic;

namespace Observer
{
    public class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(duck);
            }
        }
    }
}