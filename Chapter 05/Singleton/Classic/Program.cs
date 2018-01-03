using System;

namespace Classic
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine(singleton.Description);
        }
    }
}
