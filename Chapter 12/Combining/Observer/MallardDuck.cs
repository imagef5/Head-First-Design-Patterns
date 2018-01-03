using System;

namespace Observer
{
    public class MallardDuck : IQuackable
    {
        Observable observable;

        public MallardDuck()
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
            return "Mallard Duck";
        }
    }
}