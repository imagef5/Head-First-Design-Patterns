using System;
using System.Collections.Generic;

namespace WeatherData.Net
{
    public abstract class DisplayBase : IObserver<WeatherMeasurements>
    {
        private IDisposable unsubscriber;

        #region IObserver Implements
        public abstract void OnNext(WeatherMeasurements value);

        public virtual void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Additional weathermeasurements data will not be transmitted.");
            Unsubscribe();
        }
        #endregion
        
        public virtual void Subscribe(IObservable<WeatherMeasurements> provider)
        {
            if (provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}