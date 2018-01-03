using System;

namespace Party
{
    public class Hottub 
    {
        bool on;
        int temperature;

        public Hottub() 
        {
        }

        public void On() 
        {
            on = true;
            Console.WriteLine("Hottub is on");
        }

        public void Off() 
        {
            on = false;
            Console.WriteLine("Hottub is off");
        }

        public void Circulate() 
        {
            if (on) 
            {
                Console.WriteLine("Hottub is bubbling!");
            }
        }

        public void JetsOn() 
        {
            if (on) 
            {
                Console.WriteLine("Hottub jets are on");
            }
        }

        public void JetsOff() 
        {
            if (on) 
            {
                Console.WriteLine("Hottub jets are off");
            }
        }

        public void Temperature(int temperature) 
        {
            if (temperature > this.temperature) 
            {
                Console.WriteLine($"Hottub is heating to a steaming {temperature} degrees");
            }
            else 
            {
                Console.WriteLine($"Hottub is cooling to {temperature} degrees");
            }
            this.temperature = temperature;
        }
    }
}