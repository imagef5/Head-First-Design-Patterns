using System;

namespace ChocolateBoiler
{
    //NOTE: This is not thread safe!, don't use!
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler instance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if(instance == null)
                {
                    Console.WriteLine("Creating unique instance of Chocolate Boiler");
                    instance = new ChocolateBoiler();
                }
                Console.WriteLine("Returning instance of Chocolate Boiler");
                return instance;
            }
        }

        public bool Empty => empty;
        public bool Boiled => boiled;

        //public string Description => "";

        public void Fill() {
            if (empty) {
                empty = false;
                boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }
    
        public void Drain() {
            if (!empty && boiled) {
                // drain the boiled milk and chocolate
                empty = true;
            }
        }
    
        public void Boil() {
            if (!empty && !boiled) {
                // bring the contents to a boil
                boiled = true;
            }
        }
    }
}