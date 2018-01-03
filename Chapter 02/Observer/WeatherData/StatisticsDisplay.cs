using System;
namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement 
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum= 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(WeatherMeasurements measurements) {
            tempSum += measurements.Temperature;
            numReadings++;

            if (measurements.Temperature > maxTemp) {
                maxTemp = measurements.Temperature;
            }
    
            if (measurements.Temperature < minTemp) {
                minTemp = measurements.Temperature;
            }

            Display();
        }

        public void Display() {
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings} / {maxTemp} / {minTemp}");
        }
    }
}
