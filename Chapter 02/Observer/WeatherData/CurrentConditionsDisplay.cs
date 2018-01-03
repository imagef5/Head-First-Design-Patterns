
using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        #region Private Fields
        float temperature;
        float humidity;
        ISubject weatherData;
        #endregion

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #region IObserver Implement
        public void Update(WeatherMeasurements measurements)
        {
            this.temperature = measurements.Temperature;
            this.humidity = measurements.Humidity;
            Display();
        }
        #endregion

        #region IDisplayElement Implement
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature:0.0##}F degrees and {humidity:0.0##}% humidity");
        }
        #endregion
    }
}