using System;
using System.Collections.Generic;

namespace WeatherData.Net
{
    public struct WeatherMeasurements
    {
        public float Temperature {get; set;}
        
        public float Humidity {get; set;}
        
        public float Pressure {get; set;}
    }

    public class WeatherData : IObservable<WeatherMeasurements>
    {
        List<IObserver<WeatherMeasurements>> observers;
        WeatherMeasurements weatherMeasurements = new WeatherMeasurements();

        public WeatherData()
        {
            observers = new List<IObserver<WeatherMeasurements>>(); 
        }

        #region IObservable Implements
        public IDisposable Subscribe(IObserver<WeatherMeasurements> observer)
        {
            if (! observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
        #endregion

        #region Private Class
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherMeasurements>> _observers;
            private IObserver<WeatherMeasurements> _observer;

            public Unsubscriber(List<IObserver<WeatherMeasurements>> observers, IObserver<WeatherMeasurements> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose() 
            {
                if (! (_observer == null)) _observers.Remove(_observer);
            }
        }
        #endregion

        #region Public Method
        public void MeasurementsChanged()
        {
            foreach(var observer in observers)
            {
                observer.OnNext(weatherMeasurements);
            }
        }

        public void Mesurements(WeatherMeasurements measurements)
        {
            this.weatherMeasurements = measurements;
            MeasurementsChanged();
        }

        public void EndTransmision()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
        }
        #endregion
    }
}