namespace Party
{
    public class HottubOffCommand : ICommand
    {
        Hottub hottub;

        public HottubOffCommand(Hottub hottub) 
        {
            this.hottub = hottub;
        }
        public void Execute() 
        {
            hottub.Off();
        }
        public void Undo() 
        {
            hottub.On();
        }
    }
}