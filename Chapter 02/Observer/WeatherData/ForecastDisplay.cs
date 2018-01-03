using System;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement 
	{
		private float currentPressure = 29.92f;  
		private float lastPressure;
		private WeatherData weatherData;

		public ForecastDisplay(WeatherData weatherData) {
			this.weatherData = weatherData;
			weatherData.RegisterObserver(this);
		}

		public void Update(WeatherMeasurements measurements) {
			lastPressure = currentPressure;
			currentPressure = measurements.Pressure;

			Display();
		}

		public void Display() {
			Console.Write("Forecast: ");
			if (currentPressure > lastPressure) {
				Console.WriteLine("Improving weather on the way!");
			} else if (currentPressure == lastPressure) {
				Console.WriteLine("More of the same");
			} else if (currentPressure < lastPressure) {
				Console.WriteLine("Watch out for cooler, rainy weather");
			}
		}
	}
}