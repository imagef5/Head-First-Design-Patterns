namespace Undo
{
    public class CeilingFanLowCommand : ICommand
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.Speed;
            ceilingFan.Low();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH) {
                ceilingFan.High();
            } else if (prevSpeed == CeilingFan.MEDIUM) {
                ceilingFan.Medium();
            } else if (prevSpeed == CeilingFan.LOW) {
                ceilingFan.Low();
            } else if (prevSpeed == CeilingFan.OFF) {
                ceilingFan.Off();
            }
        }

    }
}