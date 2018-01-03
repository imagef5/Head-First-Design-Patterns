using System;

namespace Composite
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
        }
    }
}