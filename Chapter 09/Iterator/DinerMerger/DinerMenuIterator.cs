using System;

namespace DinerMerger
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        #region Implement IIterator Interface
        public bool MoveNext()
        {
            position++;
            return (position < items.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        
        public MenuItem Current
        {
            get
            {
                try
                {
                    return items[position];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    throw new InvalidOperationException();
                }
            }
        }
        #endregion
    }
}