namespace Party
{
    public class HottubOnCommand : ICommand
    {
        Hottub hottub;

        public HottubOnCommand(Hottub hottub) 
        {
            this.hottub = hottub;
        }
        public void Execute() 
        {
            hottub.On();
            hottub.Temperature(104);
            hottub.Circulate();
        }
        public void Undo() 
        {
            hottub.Off();
        }
    }
}