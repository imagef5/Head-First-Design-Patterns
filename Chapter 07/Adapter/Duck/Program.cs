using System;

namespace Duck
{
    class DuckTestDrive
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            testDuck(turkeyAdapter);
        }

        static void testDuck(IDuck duck) 
        {
            duck.Quack();
            duck.Fly();
        }
    }

    class TurkeyTestDrive
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            ITurkey duckAdapter = new DuckAdapter(duck);

            for(int i=0;i<10;i++) 
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
                Console.WriteLine();
            }
        }
    }
}
