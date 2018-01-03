using System;

namespace Adapter
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
        }
    }
}