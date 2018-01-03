using System;

namespace Ducks
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
        }
    }
}