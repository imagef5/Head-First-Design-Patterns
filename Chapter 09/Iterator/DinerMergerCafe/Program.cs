using System;

namespace DinerMergerCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

            waitress.PrintMenu();

            // Console.WriteLine("\nCustomer asks, is the Hotdog vegetarian?");
            // Console.Write("Waitress says: ");
            // if (waitress.IsItemVegetarian("핫도그")) {
            //     Console.WriteLine("Yes");
            // } else {
            //     Console.WriteLine("No");
            // }
            // Console.WriteLine("\nCustomer asks, are the Waffles vegetarian?");
            // Console.Write("Waitress says: ");
            // if (waitress.IsItemVegetarian("와플")) {
            //     Console.WriteLine("Yes");
            // } else {
            //     Console.WriteLine("No");
            // }
            
            // Console.WriteLine("\n채식메뉴");
            // waitress.VegetarianMenu();
        }
    }
}
