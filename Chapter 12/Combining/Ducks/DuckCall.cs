using System;

namespace Ducks
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
        }
    }
}