using System;

namespace HomeTheater
{
    public class DvdPlayer
    {
        string description;
        int currentTrack;
        Amplifier amplifier;
        string movie;
        
        public DvdPlayer(String description, Amplifier amplifier) 
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

        public void Eject() 
        {
            movie = null;
            Console.WriteLine($"{description} eject");
        }
    
        public void Play(String movie) 
        {
            this.movie = movie;
            currentTrack = 0;
            Console.WriteLine($"{description} playing \"{movie}\"");
        }

        public void Play(int track) 
        {
            if (movie == null) 
            {
                Console.WriteLine($"{description} can't play track {track} no dvd inserted");
            } 
            else 
            {
                currentTrack = track;
                Console.WriteLine($"{description} playing track {currentTrack} of \"{movie}\"");
            }
        }

        public void Stop() 
        {
            currentTrack = 0;
            Console.WriteLine($"{description} stopped \"{movie}\"");
        }
    
        public void Pause() {
            Console.WriteLine($"{description} paused \"{movie}\"");
        }

        public void SetTwoChannelAudio() 
        {
            Console.WriteLine($"{description} set two channel audio");
        }
    
        public void SetSurroundAudio() 
        {
            Console.WriteLine($"{description} set surround audio");
        }
    
        public override string ToString() {
            return description;
        }
    }
}