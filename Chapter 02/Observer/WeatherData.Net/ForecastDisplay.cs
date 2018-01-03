using System;
using System.Collections.Generic;

namespace WeatherData.Net
{
    public class ForecastDisplay : DisplayBase, IDisplayElement
    {
        #region Private Fields
        private float currentPressure = 29.92f;  
		private float lastPressure;
        #endregion

        #region IObserver Implements
        public override void OnNext(WeatherMeasurements value)
        {
            lastPressure = currentPressure;
			currentPressure = value.Pressure;
            Display();
        }
        #endregion

        #region IDisplayElement Implements
        public void Display()
        {
            Console.Write("Forecast: ");
			if (currentPressure > lastPressure) {
				Console.WriteLine("Improving weather on the way!");
			} else if (currentPressure == lastPressure) {
				Console.WriteLine("More of the same");
			} else if (currentPressure < lastPressure) {
				Console.WriteLine("Watch out for cooler, rainy weather");
			}
        }
        #endregion
    }
}