using System.Collections;
using System.Collections.Generic;

namespace DinerMergerCafe
{
    public class CafeMenu : IMenu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("베지 버거와 에어 프라이", "통밀빵, 상추, 토마토, 감자튀김이 첨가된 베지 버거", true, 3.99);
            AddItem("오늘의 스프", "샐러드가 곁들여진 오늘의 스프", false, 3.69);
            AddItem("베리또", "통 핀토콩과 살사, 구아카몰이 곁들여진 푸짐한 베리또", true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.Name, menuItem);
        }

        //public Hashtable MenuItems => menuItems;

        #region Implement IEnumerator<MenuItem> Interface
        public IEnumerator<MenuItem> GetEnumerator()
        {
            foreach(MenuItem menuItem in menuItems.Values)
            {
                yield return menuItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // for (int i = 0; i < this.menuItems.Count; i++)
            // {
            //     yield return this.menuItems[i];
            // }
            return this.menuItems.GetEnumerator();
        }
        #endregion
    }
}