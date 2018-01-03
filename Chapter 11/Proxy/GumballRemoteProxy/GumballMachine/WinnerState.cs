using System;
using GumballMachineRemote;

namespace GumballMachine
{
    [Serializable]
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        #region Implement IState Interface
        public void InsertQuarter()
        {
            Console.WriteLine("잠시만 기다려 주세요. 알맹이가 나가고 있습니다.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Oops~~! 잠시만 기다려 주세요. 알맹이가 나가고 있습니다.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("또다른 알맹이가 나가고 있습니다.");
        }

        public void Dispense()
        {
            Console.WriteLine("축하드립니다. 알맹이를 하나 더 받으실 수 있습니다.");
            gumballMachine.ReleaseBall();
            if(gumballMachine.Count > 0)
            {
                gumballMachine.ReleaseBall();
                if(gumballMachine.Count > 0)
                {
                    gumballMachine.State = new NoQuarterState(gumballMachine);
                }
                else
                {
                    Console.WriteLine("더 이상 알맹이가 없습니다.");
                    gumballMachine.State = new SoldOutState(gumballMachine);
                }
            }
            else
            {
                gumballMachine.State = new SoldOutState(gumballMachine);
            }
        }

        public override string ToString() 
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
        #endregion
    }
}