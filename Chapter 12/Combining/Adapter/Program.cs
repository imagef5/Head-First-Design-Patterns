using System;

namespace Adapter
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
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("Duck Simulator : With Goose Adapter");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);
        }
        void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
