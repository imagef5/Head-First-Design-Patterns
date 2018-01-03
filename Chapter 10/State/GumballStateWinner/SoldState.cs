using System;

namespace GumballStateWinner
{
    public class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("잠깐만 기다려 주세요. 알맹이가 나가고 있습니다.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("손잡이를 한번만 돌려주세요.");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.Count > 0)
            {
                gumballMachine.State = new NoQuarterState(gumballMachine);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.State = new SoldOutState(gumballMachine);
            }
        }

        public void Refill()
        {

        }

        public override string ToString()
        {
            return "알맹이가 나가는 중";
        }
    }
}