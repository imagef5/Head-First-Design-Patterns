using System;

namespace HomeTheater
{
    public interface IHomeTheaterFacade
    {
        void WatchMovie(string movie);
        void EndMovie();
        void ListenToCd(string title);
        void EndCd();
        void ListenToRadio(double frequency);
        void EndRadio();
    }

    public class HomeTheaterFacade : IHomeTheaterFacade
    {
        Amplifier amplifier;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        Screen screen;
        TheaterLights lights;
        PopcornPopper popper;

        public HomeTheaterFacade()
        {
            amplifier = new Amplifier("Top-O-Line Amplifier");
            tuner = new Tuner("Top-O-Line AM/FM Tuner", amplifier);
            dvd = new DvdPlayer("Top-O-Line DVD Player", amplifier);
            cd = new CdPlayer("Top-O-Line CD Player", amplifier);
            projector = new Projector("Top-O-Line Projector", dvd);
            lights = new TheaterLights("Theater Ceiling Lights");
            screen = new Screen("Theater Screen");
            popper = new PopcornPopper("Popcorn Popper");
        }

        public HomeTheaterFacade(Amplifier amplifier, 
                                 Tuner tuner, 
                                 DvdPlayer dvd, 
                                 CdPlayer cd,
                                 Projector projector, 
                                 Screen screen, 
                                 TheaterLights lights, 
                                 PopcornPopper popper)
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie....");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.On();
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
            Console.WriteLine();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
            Console.WriteLine();
        }

        public void ListenToCd(string title)
        {
            Console.WriteLine("Get ready for an audiopile experence...");
            lights.On();
            amplifier.On();
            amplifier.SetVolume(5);
            amplifier.SetCd(cd);
            amplifier.SetStereoSound();
            cd.On();
            cd.Play(title);
            Console.WriteLine();
        }
        
        public void EndCd()
        {
            Console.WriteLine("Shutting doen CD...");
            amplifier.SetCd(cd);
            amplifier.Off();
            cd.Eject();
            cd.Off();
            Console.WriteLine();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            tuner.On();
            tuner.SetFrequency(frequency);
            amplifier.On();
            amplifier.SetVolume(5);
            amplifier.SetTuner(tuner);
        }

        public void EndRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            tuner.Off();
            amplifier.Off();
        }
    }
}