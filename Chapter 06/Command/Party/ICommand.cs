namespace Party
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}