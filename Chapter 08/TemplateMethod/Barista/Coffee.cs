using System;

namespace Barista
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("필터로 커피를 우려내는 중");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("설탕과 커피를 추가하는 중");
        }
    }
}