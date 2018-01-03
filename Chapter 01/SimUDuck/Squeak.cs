using System;

public class Squeak : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("삑");
    }
}