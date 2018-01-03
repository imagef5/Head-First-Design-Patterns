using System;

namespace Composite
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
        }
    }
}