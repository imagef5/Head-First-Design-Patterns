using System.Collections;
using System.Collections.Generic;

namespace DinerMergerDotNet
{
    public class PancakeHouseMenu : IMenu
    {
        List<MenuItem> menuItems;
        
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K&B 팬케이크 세트","스크램블드 에그와 토스트가 곁들어진 팬테이크", true, 2.99);
            AddItem("레귤러 팬케이크 세트","달걀 후라이와 소시지가 곁들여진 팬케이크", false, 2.99);
            AddItem("블루베리 팬케이크","신선한 블루베리와 블루베리 시럽으로 만든 팬케이크", true, 3.94);
            AddItem("와플","와플, 취향에 따라 블루베리나 딸기를 얹을 수 있습니다.", true, 3.95);
        }

        public void AddItem(string name, string desceiprion, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, desceiprion, vegetarian, price);
            menuItems.Add(menuItem);
        }

        #region Implement IEnumerable<MenuItem> Interface
        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Count; i++)
            {
                yield return this.menuItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Count; i++)
            {
                yield return this.menuItems[i];
            }
        }
        #endregion
    }
}