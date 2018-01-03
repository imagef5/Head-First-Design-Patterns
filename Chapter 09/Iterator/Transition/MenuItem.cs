namespace Transition
{
    public class MenuItem
    {
        string name;
        string description;
        bool vegeterian;
        double price;

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegeterian = vegeterian;
            this.price = price;
        }

        public string Name => name;
        public string Description => description;
        public bool Vegeterian => vegeterian;
        public double Price => price;
    }
}