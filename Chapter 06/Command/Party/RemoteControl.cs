
using System.Collections.Generic;
using System.Text;

namespace Party
{
    public class RemoteControl
    {
        private const int COMMAND_COUNT = 7;
        // #region List<ICommand> 로 구현하는 경우
        // List<ICommand> onCommands;
        // List<ICommand> offCommands;
        // #endregion

        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;
        public RemoteControl()
        {
            // #region List<ICommand> 로 구현하는 경우
            // onCommands = new List<ICommand>();
            // offCommands = new List<ICommand>();
            // #endregion

            onCommands = new ICommand[COMMAND_COUNT];
            offCommands = new ICommand[COMMAND_COUNT];
            for(int i = 0 ; i < COMMAND_COUNT ; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }

            undoCommand = new NoCommand();
        }

        public void AddCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        #region List<ICommand> 로 구현하는 경우
        // public int AddCommand(ICommand onCommand, ICommand offCommand)
        // {
        //     onCommands.Add(onCommand);
        //     offCommands.Add(offCommand);

        //     return onCommands.IndexOf(onCommand);
        // }
        #endregion
        
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed() 
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("\n--- Remote Control ---\n");
            for (int i = 0; i < this.onCommands.Length; ++i)
                output.AppendLine($"[slot {i}] {this.onCommands[i].GetType().Name} {offCommands[i].GetType().Name}");

            output.AppendLine($"[undo] {undoCommand.GetType().Name}");
            return output.ToString();
        }
    }
}