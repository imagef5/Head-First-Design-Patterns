using System;

namespace Observer
{
    public class RedheadDuck : IQuackable
    {
        Observable observable;

        public RedheadDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
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
            return "Redhead Duck";
        }
    }
}