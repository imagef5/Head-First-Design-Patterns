using System;

namespace Composite
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public static int NumberOfQuacks => numberOfQuacks;

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }
    }
}