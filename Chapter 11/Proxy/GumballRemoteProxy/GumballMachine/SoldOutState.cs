using System;
using GumballMachineRemote;

namespace GumballMachine
{
    [Serializable]
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("죄송합니다. 매진 되었습니다. 동전을 넣을 수 없습니다.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("죄송합니다. 매진 되었습니다. 반환될 동전이 없습니다.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("죄송합니다. 매진 되었습니다. 알맹이가 나갈 수 없습니다.");
        }

        public void Dispense()
        {
            Console.WriteLine("매진입니다.알맹이가 나갈 수 없습니다.");
        }

        // public void Refill()
        // {
        //     gumballMachine.State = new NoQuarterState(gumballMachine);
        // }

        public override string ToString()
        {
            return "매진";
        }
    }
}