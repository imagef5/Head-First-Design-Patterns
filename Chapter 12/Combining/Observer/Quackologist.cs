using System;

namespace Observer
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quacklogist : {duck} just Quacked.");
        }
    }
}