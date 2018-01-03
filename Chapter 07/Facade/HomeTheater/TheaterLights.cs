using System;

namespace HomeTheater
{
    public class TheaterLights
    {
        string description;
        int dimLevel;

        public TheaterLights(string description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void Dim(int level)
        {
            dimLevel = level;
            Console.WriteLine($"{description} dimming to {level}%");
        }

        public override string ToString()
        {
            return description;
        }
    }
}