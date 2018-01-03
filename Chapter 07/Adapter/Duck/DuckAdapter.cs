using System;

namespace Duck
{
    public class DuckAdapter : ITurkey
    {
        IDuck duck;
        Random rand;
        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
            rand = new Random();
        }
        public void Gobble()
        {
            duck.Quack();
        }

        public void Fly()
        {
            if(rand.Next(5) == 0)
            {
                duck.Fly();
            }
        } 
    }
}