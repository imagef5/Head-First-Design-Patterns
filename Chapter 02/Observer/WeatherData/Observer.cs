namespace ObserverPattern
{
    public interface IDisplayElement
    {
        void Display();
    }

    public interface IObserver
    {
        void Update(WeatherMeasurements measurements);
    }
}