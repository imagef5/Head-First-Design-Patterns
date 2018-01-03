using System;

namespace Party
{
    public class Light
    {
        string location = string.Empty;
        int level;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            level = 100;
            Console.WriteLine($"{location} Light is on");
        }

        public void Off()
        {
            level = 0;
            Console.WriteLine($"{location} Light is off");
        }

        public void Dim(int level) 
        {
            this.level = level;
            if (level == 0) 
            {
                Off();
            }
            else 
            {
                Console.WriteLine($"Light is dimmed to {level}%");
            }
        }

        public int Level 
        {
            get => level;
        }
    }
}