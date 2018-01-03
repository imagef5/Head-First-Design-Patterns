using System;

namespace HomeTheater
{
    public class Screen
    {
        string description;

        public Screen(string description) 
        {
            this.description = description;
        }

        public void Up() 
        {
            Console.WriteLine($"{description} going up");
        }

        public void Down() 
        {
            Console.WriteLine($"{description} going down");
        }


        public override string ToString() 
        {
            return description;
        }
    }
}