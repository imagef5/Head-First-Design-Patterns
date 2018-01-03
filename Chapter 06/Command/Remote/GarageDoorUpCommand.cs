
namespace Remote
{
    public class GarageDoorUpCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Up();
        }
    }
}