using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            // create the readings
            WeatherMeasurements readings = new WeatherMeasurements();
            readings.Temperature = 80f;
            readings.Humidity = 65f;
            readings.Pressure = 30.4f;

            weatherData.Mesurements(readings);

            readings.Temperature = 82f;
            readings.Humidity = 70f;
            readings.Pressure = 29.2f;
            weatherData.Mesurements(readings);

            readings.Temperature = 78f;
            readings.Humidity = 90f;
            weatherData.Mesurements(readings);
        }
    }
}
