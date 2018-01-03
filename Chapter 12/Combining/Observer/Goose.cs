using System;

namespace Observer
{
    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("홍홍~~~");
        }

        public override string ToString()
        {
            return "Goose";
        }
    }
}