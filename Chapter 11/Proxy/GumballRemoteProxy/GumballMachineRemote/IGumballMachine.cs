using System;

namespace GumballMachineRemote
{
    public interface IGumballMachine
    {
        int Count { get; }
        string Location { get; }
        string StateComment { get; }
    }
}
