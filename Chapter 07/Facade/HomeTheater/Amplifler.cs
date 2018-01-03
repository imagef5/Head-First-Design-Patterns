using System;

namespace HomeTheater
{
    public class Amplifier
    {
        string description;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        int volumeLevel;

        public Amplifier(string description)
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
    
        public void SetStereoSound() 
        {
            Console.WriteLine($"{description} stereo mode on");
        }
    
        public void SetSurroundSound() 
        {
            Console.WriteLine($"{description} surround sound on (5 speakers, 1 subwoofer)");
        }
    
        public void SetVolume(int level) 
        {
            volumeLevel = level;
            Console.WriteLine($"{description} setting volume to {level}");
        }

        public void SetTuner(Tuner tuner) 
        {
            Console.WriteLine($"{description} setting tuner to {dvd}");
            this.tuner = tuner;
        }
    
        public void SetDvd(DvdPlayer dvd) 
        {
            Console.WriteLine($"{description} setting DVD player to {dvd}");
            this.dvd = dvd;
        }
    
        public void SetCd(CdPlayer cd) 
        {
            Console.WriteLine($"{description} setting CD player to {cd}");
            this.cd = cd;
        }
    
        public override string ToString() 
        {
            return description;
        }
    }
}