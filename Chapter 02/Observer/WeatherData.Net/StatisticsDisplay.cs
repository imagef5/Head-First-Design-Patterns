using System;
using System.Collections.Generic;

namespace WeatherData.Net
{
    public class StatisticsDisplay : DisplayBase, IDisplayElement
    {
        #region Private Fields
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum= 0.0f;
        private int numReadings;       
        #endregion

        #region IObserver Implements
        public override void OnNext(WeatherMeasurements value)
        {
            tempSum += value.Temperature;
            numReadings++;

            if (value.Temperature > maxTemp) {
                maxTemp = value.Temperature;
            }
    
            if (value.Temperature < minTemp) {
                minTemp = value.Temperature;
            }
            Display();
        }
        #endregion

        #region IDisplayElement Implements
        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings} / {maxTemp} / {minTemp}");
        }
        #endregion
    }
}