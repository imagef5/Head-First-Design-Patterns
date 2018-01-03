using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMergerCafe
{
    public class AlteratingDinerMenu : IEnumerable<MenuItem>
    {
        MenuItem[] menuItems;
        int position;
        public AlteratingDinerMenu(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
            var position = ((int)DateTime.Now.DayOfWeek + 1) % 2;
        }
        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                if(menuItems[position] != null && position < menuItems.Length)
                    yield return this.menuItems[position];
                
                position = position + 2;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                if(menuItems[position] != null && position < menuItems.Length)
                    yield return this.menuItems[position];
                
                position = position + 2;
            }
        }
    }
}