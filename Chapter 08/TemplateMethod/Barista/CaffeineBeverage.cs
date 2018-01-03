using System;

namespace Barista
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            boilWater();
            Brew();
            pourInCup();
            AddCondiments();
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
    }
}