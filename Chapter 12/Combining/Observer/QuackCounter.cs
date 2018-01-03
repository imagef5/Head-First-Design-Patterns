using System;

namespace Observer
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks;
        Observable observable;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
            observable = new Observable(this);
        }

        public static int NumberOfQuacks => numberOfQuacks;

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
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
            return duck.ToString();
        }
    }
}