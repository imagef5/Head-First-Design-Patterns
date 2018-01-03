using System;

namespace Barista
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("차를 우려내는 중");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("레몬을 추가하는 중");
        }
    }
}