
namespace Remote
{
    public class GarageDoorDownCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Down();
        }
    }
}