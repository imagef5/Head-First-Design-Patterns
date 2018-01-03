using System;

namespace Decorator
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
        }
    }
}