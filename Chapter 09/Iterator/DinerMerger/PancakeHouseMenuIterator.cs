using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMerger
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> items;
        int position = -1;
        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        #region Implement IIterator Interface
        public bool MoveNext()
        {
            position++;
            return (position < items.Count);
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