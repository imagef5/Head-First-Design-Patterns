using System;

namespace Adapter
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
        }
    }
}