namespace Party
{
    public class StereoOnCommand : ICommand
    {
        Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}