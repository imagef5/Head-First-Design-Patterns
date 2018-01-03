using System;

namespace Factory
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑~~");
        }
    }
}