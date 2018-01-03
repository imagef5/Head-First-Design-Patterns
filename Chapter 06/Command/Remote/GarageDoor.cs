using System;

namespace Remote
{
    public class GarageDoor
    {
        string location;
        public GarageDoor(string location)
        {
            this.location = location;
        }

        public void Up()
        {
            Console.WriteLine($"{location} Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine($"{location} Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine($"{location} Garage Door is Stopped");
        }

        public void LightOn()
        {
            Console.WriteLine($"{location} Garage Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine($"{location} Garage Light is Off");
        }
    }
}