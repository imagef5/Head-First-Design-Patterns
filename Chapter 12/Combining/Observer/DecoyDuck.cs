using System;

namespace Observer
{
    public class DecoyDuck : IQuackable
    {
        Observable observable;

        public DecoyDuck()
        {
            observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
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
            return "Docoy Duck";
        }
    }
}