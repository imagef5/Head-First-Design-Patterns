using System;
using GumballMachineRemote;

namespace GumballMonitor
{
    public class GumballMonitor 
    {
        IGumballMachine gumballMachine;

        public GumballMonitor(IGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Report()
        {
            try
            {
                Console.WriteLine($"뽑기 기계 위치 : {gumballMachine.Location}");
                Console.WriteLine($"현재 재고 : {gumballMachine.Count}");
                Console.WriteLine($"현재 상태 : {gumballMachine.StateComment}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}