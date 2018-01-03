
using System.Collections.Generic;

namespace ObserverPattern
{
    public struct WeatherMeasurements
    {
        public float Temperature;
        public float Humidity;
        public float Pressure;
    }
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public class WeatherData : ISubject
    {
        #region Private Fields Area
        List<IObserver> observers;
        WeatherMeasurements weatherMeasurements = new WeatherMeasurements();
        #endregion

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        #region ISubject Implement
        public void RegisterObserver(IObserver o)
        {
            if(!observers.Contains(o))
                observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if(observers.Contains(o))
                observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(weatherMeasurements);
            }
        }
        #endregion

        #region Public Method
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void Mesurements(WeatherMeasurements measurements)
        {
            this.weatherMeasurements = measurements;
            MeasurementsChanged();
        }
        #endregion
    }
}


