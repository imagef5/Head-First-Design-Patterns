using System;

namespace ObserverPattern
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        #region Private Fields
        float heatIndex = 0.0f;
        ISubject weatherData;
        #endregion
        public HeatIndexDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #region IObserver Implements
        public void Update(WeatherMeasurements measurements)
        {
            heatIndex = computeHeatIndex(measurements.Temperature, measurements.Humidity);
            Display();
        }
        #endregion

        #region IDisplayElement Implements
        public void Display()
        {
            Console.WriteLine($"Heat index is {heatIndex}");
        }
        #endregion

        #region Private Method Area
        private float computeHeatIndex(float t, float rh) 
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) 
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) 
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 * 
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) + 
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }
        #endregion
    }
}