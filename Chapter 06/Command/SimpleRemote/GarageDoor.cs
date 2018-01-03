using System;

namespace SimpleRemote
{
    public class GarageDoor
    {
        public GarageDoor()
        {
            
        }

        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door is Stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Light is Off");
        }
    }
}