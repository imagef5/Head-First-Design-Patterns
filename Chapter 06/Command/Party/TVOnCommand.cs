namespace Party
{
    public class TVOnCommand : ICommand 
    {
        TV tv;

        public TVOnCommand(TV tv) 
        {
            this.tv= tv;
        }

        public void Execute() 
        {
            tv.On();
            tv.InputChannel();
        }

        public void Undo() 
        {
            tv.Off();
        }
    }
}