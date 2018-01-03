using System;

namespace MenuIterator
{
    public class Waitress
    {
        IMenuComponent allMenus;

        public Waitress(IMenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("채식주의자용 메뉴");
            Console.WriteLine("-------------------");
            foreach(var item in allMenus)
            {
                if(item is MenuItem)
                {
                    if(item.IsVegetarian)
                    {
                        item.Print();
                    }
                }
            }
        }
    }
}