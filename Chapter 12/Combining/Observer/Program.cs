using System;

namespace Observer
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
            //IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);
            
            Console.WriteLine("\nDuck Simulator : With Observer");
            
            Quackologist quackologist = new Quackologist();
		    flockOfDucks.RegisterObserver(quackologist);

		    simulate(flockOfDucks);

            
            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }
        void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
