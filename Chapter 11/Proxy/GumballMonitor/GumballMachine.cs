using System;
using System.Text;

namespace GumballMonitor
{
    public class GumballMachine
    {
        IState state;
        string location;
        int count;

        public GumballMachine(string location, int balls)
        {
            this.location = location;
            this.count = (balls < 0) ? 0 : balls ;
            if(balls > 0)
                state = new NoQuarterState(this);
            else
                state = new SoldOutState(this);
        }

        public IState State
        {
            get => state;
            set 
            {
                state = value;
            }
        }

        public string Location => location;
        public int Count => count;

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        public void Refill(int balls)
        {
            count += (balls < 0) ? 0 : balls;
            Console.WriteLine($"The gumball machine was just refilled; it's new count is: {count}");
		    state.Refill();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot....");
            if(count > 0)
            {
                count = count - 1;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("\nMighty Gumball, Inc.");
            result.AppendLine("C# 으로 돌아가는 2017년형 뽑기기계");
            result.AppendLine($"남은개수: {count} 개");

            result.Append($"현재 뽑기상태는 : {state}");
            result.AppendLine();

            return result.ToString();
        }
    }
}