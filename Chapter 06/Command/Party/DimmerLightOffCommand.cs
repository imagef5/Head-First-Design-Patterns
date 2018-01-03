namespace Party
{
    public class DimmerLightOffCommand : ICommand
    {
        Light light;
        int prevLevel;

        public DimmerLightOffCommand(Light light)
        {
            this.light = light;
            prevLevel = 100;
        }

        public void Execute()
        {
            prevLevel = light.Level;
            light.Off();
        }

        public void Undo()
        {
            light.Dim(prevLevel);
        }
    }
}