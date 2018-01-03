using System;

namespace Adapter
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
        }
    }
}