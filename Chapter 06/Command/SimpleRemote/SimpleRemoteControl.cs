
namespace SimpleRemote
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl()
        {

        }

        public ICommand Command
        {
            set 
            {
                slot = value;
            }
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}