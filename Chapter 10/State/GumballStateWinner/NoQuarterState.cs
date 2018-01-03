using System;

namespace GumballStateWinner
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;
        //IState state;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            //this.state = gumballMachine.State;
        }

        #region Implement IState Interface
        public void InsertQuarter()
        {
            Console.WriteLine("동전을 넣으셨습니다.");
            gumballMachine.State = new HasQuarterState(gumballMachine);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("동전을 넣어주세요.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("동전을 넣어주세요.");
        }

        public void Dispense()
        {
            Console.WriteLine("동전을 넣어주세요.");
        }

        public void Refill()
        {
            
        }

        public override string ToString()
        {
            return "동전 투입 대기중";
        }
        #endregion
    }
}