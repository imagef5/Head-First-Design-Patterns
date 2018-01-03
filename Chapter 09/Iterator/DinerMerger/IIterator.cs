namespace DinerMerger
{
    public interface IIterator
    {
        bool MoveNext();
        void Reset();
        MenuItem Current {get;}
    }
}