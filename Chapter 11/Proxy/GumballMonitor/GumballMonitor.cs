using System;

namespace GumballMonitor
{
    public class GumballMonitor
    {
        GumballMachine gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"뽑기 기계 위치 : {gumballMachine.Location}");
            Console.WriteLine($"현재 재고 : {gumballMachine.Count}");
            Console.WriteLine($"현재 상태 : {gumballMachine.State}");
        }
    }
}