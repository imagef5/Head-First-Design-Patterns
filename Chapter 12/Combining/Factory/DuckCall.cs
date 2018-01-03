using System;

namespace Factory
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉~~");
        }
    }
}