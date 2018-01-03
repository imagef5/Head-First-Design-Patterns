using System;
using System.Collections;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[]
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("정렬 전:");
            display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\n정렬 후:");
            display(ducks);
        }

        static void display(Duck[] ducks)
        {
            foreach(var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
