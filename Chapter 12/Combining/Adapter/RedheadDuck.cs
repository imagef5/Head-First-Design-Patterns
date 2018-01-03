using System;

namespace Adapter
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥~~");
        }
    }
}