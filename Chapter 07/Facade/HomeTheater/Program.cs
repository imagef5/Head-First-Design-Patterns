using System;

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
