using System;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("저는 못 날아요.");
    }
}