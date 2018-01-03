using System;

namespace Ducks
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
            IQuackable mallardDuck = new MallardDuck();
            IQuackable redheadDuck = new RedheadDuck();
            IQuackable duckCall = new DuckCall();
            IQuackable rubberDuck = new RubberDuck();

            Console.WriteLine("Duck Simulator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
        }
        void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
