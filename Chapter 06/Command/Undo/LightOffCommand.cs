
namespace Undo
{
    public class LightOffCommand : ICommand
    {
        Light light;
        int level;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            level = light.Level;
            light.Off();
        }

        public void Undo()
        {
            light.Dim(level);
        }
    }
}