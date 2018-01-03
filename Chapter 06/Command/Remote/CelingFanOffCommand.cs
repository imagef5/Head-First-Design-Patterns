namespace Remote
{
    public class CeilingFanOffCommand : ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.Off();
        }
    }
}