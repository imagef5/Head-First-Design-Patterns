using System;

namespace Observer
{
    public class RubberDuck : IQuackable
    {
        Observable observable;

        public RubberDuck()
        {
            observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}