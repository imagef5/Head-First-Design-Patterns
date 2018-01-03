using System;

namespace Observer
{
    public class DuckCall : IQuackable
    {
        Observable observable;
        public DuckCall()
        {
            observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
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
            return "Duck Call";
        }
    }
}