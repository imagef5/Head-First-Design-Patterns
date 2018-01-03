namespace Undo
{
    public class DimmerLightOnCommand : ICommand
    {
        Light light;
        int prevLevel;

        public DimmerLightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            prevLevel = light.Level;
            light.Dim(75);
        }

        public void Undo()
        {
            light.Dim(prevLevel);
        }
    }
}