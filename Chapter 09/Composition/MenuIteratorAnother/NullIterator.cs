using System.Collections;
using System.Collections.Generic;

namespace MenuIteratorAnother
{
    public class NullIterator : IEnumerator<IMenuComponent>
    {
        public IMenuComponent Current => null;

        object IEnumerator.Current => null;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            
        }
    }
}