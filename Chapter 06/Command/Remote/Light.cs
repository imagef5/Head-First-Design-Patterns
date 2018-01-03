using System;

namespace Remote
{
    public class Light
    {
        string location = string.Empty;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"{location} Light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} Light is off");
        }
    }
}