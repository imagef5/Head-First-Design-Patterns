using System;

public class MuteQuack : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("<< 조용 ~ >>");
    }
}