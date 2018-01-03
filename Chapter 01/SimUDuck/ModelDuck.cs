using System;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("저는 모형 오리입니다.");
    }
}