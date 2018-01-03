using System;

namespace HomeTheater
{
    public class Projector 
    {
        string description;
        DvdPlayer dvdPlayer;
        
        public Projector(string description, DvdPlayer dvdPlayer) 
        {
            this.description = description;
            this.dvdPlayer = dvdPlayer;
        }
    
        public void On() {
            Console.WriteLine($"{description} on");
        }
    
        public void Off() 
        {
            Console.WriteLine($"{description} off");
        }

        public void WideScreenMode() 
        {
            Console.WriteLine($"{description} in widescreen mode (16x9 aspect ratio)");
        }

        public void TvMode() 
        {
            Console.WriteLine($"{description} in tv mode (4x3 aspect ratio)");
        }
    
        public override string ToString() 
        {
            return description;
        }
    }
}