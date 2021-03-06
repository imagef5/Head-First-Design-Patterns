using System;

namespace GumballState
{
    public class HasQuarterState : IState
    {
        GumballMachine gumballMachine;
        //IState state;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            //this.state = gumballMachine.State;
        }

        #region Implement IState Interface
        public void InsertQuarter()
        {
            Console.WriteLine("동전은 한개만 넣어주세요.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("동전이 반환됩니다.");
            gumballMachine.State = new NoQuarterState(gumballMachine);
        }

        public void TurnCrank()
        {
            Console.WriteLine("손잡이를 돌리셨습니다.");
            gumballMachine.State = new SoldState(gumballMachine);
        }

        public void Dispense()
        {
            Console.WriteLine("알맹이가 나갈 수 없습니다.");
        }

        public void Refill()
        {
            
        }

        public override string ToString() 
        {
            return "손잡이 돌리기 대기중";
        }
        #endregion
    }
}