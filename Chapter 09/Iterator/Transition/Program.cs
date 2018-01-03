using System.Collections.Generic;

namespace Transition
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            List<IMenu> menus = new List<IMenu>();
            menus.Add(pancakeHouseMenu);
            menus.Add(dinerMenu);
            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();

        }
    }
}
