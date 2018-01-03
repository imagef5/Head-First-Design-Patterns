using System;
using System.Collections.Generic;

namespace Transition
{
    public class Waitress
    {
        List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach(var menu in menus)
            {
                printMenu(menu);
            }
        }

        private void printMenu(IMenu iterator)
        {
            foreach(var menuItem in iterator)
            {
                Console.WriteLine($"{menuItem.Name} , {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}