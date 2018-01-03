using System;

namespace HomeTheater
{
    public class Tuner
    {
        string description = string.Empty;
        Amplifier amplifier;
        double frequency;

        public Tuner(String description, Amplifier amplifier) 
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void On() 
        {
            Console.WriteLine($"{description} on");
        }

        public void Off() 
        {
            Console.WriteLine($"{description} off");
        }

        public void SetFrequency(double frequency) 
        {
            Console.WriteLine($"{description} setting frequency to {frequency}");
            this.frequency = frequency;
        }

        public void SetAm() 
        {
            Console.WriteLine($"{description} setting AM mode");
        }

        public void SetFm() 
        {
            Console.WriteLine($"{description} setting FM mode");
        }

        public override string ToString() 
        {
            return description;
        }
    }
}