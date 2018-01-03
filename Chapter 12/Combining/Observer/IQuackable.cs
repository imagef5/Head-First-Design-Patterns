namespace Observer
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}