using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program simulator = new Program();
            simulator.simulate();
        }

        void simulate()
        {
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            IQuackable duckCall = new QuackCounter(new DuckCall());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("Duck Simulator : With Decorator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }
        void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
