
namespace Undo
{
    public class LightOnCommand : ICommand
    {
        Light light;
        int prevLevel;

        public LightOnCommand(Light light)
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