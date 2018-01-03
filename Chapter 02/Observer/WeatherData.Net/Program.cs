using System;

namespace WeatherData.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay();

            currentDisplay.Subscribe(weatherData);
            statisticsDisplay.Subscribe(weatherData);
            forecastDisplay.Subscribe(weatherData);
            heatIndexDisplay.Subscribe(weatherData);
            
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
