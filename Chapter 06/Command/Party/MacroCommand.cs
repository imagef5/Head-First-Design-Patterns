using System.Collections.Generic;

namespace Party
{
    public class MacroCommand : ICommand
    {
        List<ICommand> commands ;

        public MacroCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach(var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach(var command in commands)
            {
                command.Undo();
            }
        }
    }
}