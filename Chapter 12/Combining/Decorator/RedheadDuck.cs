using System;

namespace Decorator
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
        }
    }
}