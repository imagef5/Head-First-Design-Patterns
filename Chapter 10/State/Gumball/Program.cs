using System;

namespace Gumball
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            //동전넣기 -> 손잡이 돌리기
            Console.WriteLine("동전넣기 -> 손잡이 돌리기");
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            //동전넣기 -> 동전반환 -> 손잡이 돌리기
            Console.WriteLine("동전넣기 -> 동전반환 -> 손잡이 돌리기");
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            //동전넣기 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기 -> 동전반환
            Console.WriteLine("동전넣기 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기 -> 동전반환");
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine(gumballMachine);

            //동전넣기 x 2 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기
            Console.WriteLine("동전넣기 x 2 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기 -> 동전넣기 -> 손잡이 돌리기");
            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
