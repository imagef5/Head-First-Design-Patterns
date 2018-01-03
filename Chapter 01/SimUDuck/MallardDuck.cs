using System;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("저는 물오리입니다.");
    }
}