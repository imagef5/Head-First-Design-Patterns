using System;

namespace DinerMerger
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            PrintBreakfaseMenu();
            PrintLunchMenu();
        }

        public void PrintBreakfaseMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.GetEnumerator();
            Console.WriteLine("메뉴\n----\n아침메뉴");
            printMenu(pancakeIterator);
        }

        public void PrintLunchMenu()
        {
            IIterator dinerIterator = dinerMenu.GetEnumerator();
            Console.WriteLine("\n점심메뉴");
            printMenu(dinerIterator);
        }

        public void VegetarianMenu()
        {
            printVegetarianMenu(pancakeHouseMenu.GetEnumerator());
            printVegetarianMenu(dinerMenu.GetEnumerator());
        }

        private void printMenu(IIterator iterator)
        {
            while(iterator.MoveNext())
            {
                var menuItem = iterator.Current;
                Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            }
        }

        public bool IsItemVegetarian(String name) 
        {
            IIterator breakfastIterator = pancakeHouseMenu.GetEnumerator();
            if (isVegetarian(name, breakfastIterator)) 
            {
                return true;
            }
            IIterator dinnerIterator = dinerMenu.GetEnumerator();
            if (isVegetarian(name, dinnerIterator)) 
            {
                return true;
            }
            return false;
        }


        private void printVegetarianMenu(IIterator iterator) 
        {
            while (iterator.MoveNext()) 
            {
                var menuItem = iterator.Current;
                if (menuItem.Vegeterian) 
                {
                    Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
                }
            }
        }

        private bool isVegetarian(String name, IIterator iterator) 
        {
            while (iterator.MoveNext()) 
            {
                var menuItem = iterator.Current;
                if (menuItem.Name.Equals(name)) 
                {
                    if (menuItem.Vegeterian) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}