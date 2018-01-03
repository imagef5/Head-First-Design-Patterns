using System;
public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {

    }

    #region Property Area
    public IFlyBehavior FlyBehavior
    {
        set
        {
            flyBehavior = value;
        }
    }

    public IQuackBehavior QuackBehavior
    {
        set
        {
            quackBehavior = value;
        }
    }
    #endregion

    #region Public Method
    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.quack();
    }

    public void Swim()
    {
        Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠.");
    }
    #endregion
}