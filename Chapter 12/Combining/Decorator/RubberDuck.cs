using System;

namespace Decorator
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
        }
    }
}