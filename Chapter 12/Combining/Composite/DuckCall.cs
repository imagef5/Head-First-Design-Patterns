using System;

namespace Composite
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
        }
    }
}