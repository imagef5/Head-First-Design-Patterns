namespace Party
{
    public class TVOffCommand : ICommand 
    {
        TV tv;

        public TVOffCommand(TV tv) 
        {
            this.tv= tv;
        }

        public void Execute() 
        {
            tv.Off();
            //tv.InputChannel();
        }

        public void Undo() 
        {
            tv.On();
        }
    }
}