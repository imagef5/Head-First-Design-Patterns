using System.Collections.Generic;

namespace Composite
{
    public class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }
        public void Quack()
        {
            foreach(var quacker in quackers)
            {
                quacker.Quack();
            }
        }
    }
}