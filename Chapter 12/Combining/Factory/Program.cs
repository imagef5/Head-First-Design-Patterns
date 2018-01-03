using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Program simulator = new Program();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.simulate(duckFactory);
        }

        void simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("Duck Simulator : With Abstract Factory");

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
