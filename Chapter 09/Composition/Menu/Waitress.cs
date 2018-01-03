namespace Menu
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
    }
}