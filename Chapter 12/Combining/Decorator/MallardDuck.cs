using System;

namespace Decorator
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
        }
    }
}