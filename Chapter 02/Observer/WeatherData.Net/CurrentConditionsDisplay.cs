using System;
using System.Collections.Generic;

namespace WeatherData.Net
{
    public class CurrentConditionsDisplay : DisplayBase, IDisplayElement
    {
        #region Private Fields
        float temperature;
        float humidity;
        #endregion

        #region IObserver Implements
        public override void OnNext(WeatherMeasurements value)
        {
            this.temperature = value.Temperature;
            this.humidity = value.Humidity;
            Display();
        }
        #endregion

        #region IDisplayElement Implements
        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature:0.0##}F degrees and {humidity:0.0##}% humidity");
        }
        #endregion
    }
}