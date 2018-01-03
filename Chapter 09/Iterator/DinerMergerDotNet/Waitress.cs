using System;
using System.Collections.Generic;
using System.Linq;

namespace DinerMergerDotNet
{
    public class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
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
            //IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.GetEnumerator();
            Console.WriteLine("메뉴\n----\n아침메뉴");
            printMenu(pancakeHouseMenu);
        }

        public void PrintLunchMenu()
        {
            //IEnumerator<MenuItem> dinerIterator = dinerMenu.GetEnumerator();
            Console.WriteLine("\n점심메뉴");
            printMenu(dinerMenu);
        }

        public void VegetarianMenu()
        {
            printVegetarianMenu(pancakeHouseMenu);
            printVegetarianMenu(dinerMenu);
        }

        private void printMenu(IMenu iterator)
        {
            foreach(var menuItem in iterator)
            {
                Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            }
            // while(iterator.GetEnumerator().MoveNext())
            // {
            //     var menuItem = iterator.GetEnumerator().Current;
            //     Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            // }
        }

        public bool IsItemVegetarian(string name) 
        {
            //IEnumerator<MenuItem> breakfastIterator = pancakeHouseMenu.GetEnumerator();
            if (isVegetarian(name, pancakeHouseMenu)) 
            {
                return true;
            }
            //IEnumerator<MenuItem> dinnerIterator = dinerMenu.GetEnumerator();
            if (isVegetarian(name, dinerMenu)) 
            {
                return true;
            }
            return false;
        }


        private void printVegetarianMenu(IMenu iterator) 
        {
            var vegetrianMenus = iterator.Where(s => s.Vegeterian == true);
            foreach(var menuItem in vegetrianMenus)
            {
                Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            }
            // while (iterator.GetEnumerator().MoveNext()) 
            // {
            //     var menuItem = iterator.GetEnumerator().Current;
            //     if (menuItem.Vegeterian) 
            //     {
            //         Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            //     }
            // }
        }

        private bool isVegetarian(String name, IMenu iterator) 
        {
            var val = iterator.Any(s => s.Name == name && s.Vegeterian == true);
            return val;
            // foreach(var menuItme in iterator)
            // {
            //     if(menuItme.Name.Equals(name))
            //     {
            //         if(menuItme.Vegeterian)
            //             return true;
            //     }
            // }
            // while (iterator.GetEnumerator().MoveNext()) 
            // {
            //     var menuItem = iterator.GetEnumerator().Current;
            //     if (menuItem.Name.Equals(name)) 
            //     {
            //         if (menuItem.Vegeterian) 
            //         {
            //             return true;
            //         }
            //     }
            // }
            //return false;
        }
    }
}