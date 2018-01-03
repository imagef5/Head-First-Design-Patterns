using System;

namespace Barista
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareReceipe()
        {
            boilWater();
            Brew();
            pourInCup();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        void boilWater()
        {
            Console.WriteLine("물 끓이는 중");
        }

        void pourInCup()
        {
            Console.WriteLine("컵에 따르는 중");
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}