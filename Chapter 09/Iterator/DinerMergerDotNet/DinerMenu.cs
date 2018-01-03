using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMergerDotNet
{
    public class DinerMenu : IMenu
    {
        readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("채식주의자용 BLT", "통밀 위에(식물성)베이컨, 상추, 토마토를 얹은 메뉴", true, 2.99);
            AddItem("BLT", "통밀 위에 베이컨, 상추, 토마토를 얹은 메뉴", false, 2.99);
            AddItem("오늘의 스프", "감자 샐러드를 곁들인 오늘의 스프", false, 3.29);
            AddItem("핫도그", "샤워크라우트, 갖은 양념, 양파, 치즈가 곁들여진 핫도그", false, 3.05);
            AddItem("찐 채소와 브라운 라이스","찐 채소와 브라운 라이스의 절묘한 조화", true, 3.99);
            AddItem("파스타","마리나라 소스 스파게티. 효모빵도 드립니다.", true, 3.89);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if(numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("죄송합니다. 메뉴가 꽉 찼습니다. 더 이상 추가할 수 없습니다.");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        #region Implement IEnumerable<MenuItem> Interface
        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                yield return this.menuItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                yield return this.menuItems[i];
            }
        }
        #endregion
    }
}