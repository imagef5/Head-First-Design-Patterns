using System;

namespace Party
{
    public class TV
    {
        string location = string.Empty;
        int channel;

        public TV(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"{location} TV is on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} TV is off");
        }

        public void InputChannel()
        {
            channel = 3;
            Console.WriteLine($"{location} TV channel is set of DVD");
        }
    }
}