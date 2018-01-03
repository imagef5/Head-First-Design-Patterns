using System;

namespace Undo
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remoteControl.AddCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n------ Ceiling Fan -------");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            
            remoteControl.AddCommand(1, ceilingFanMedium, ceilingFanOff);
            remoteControl.AddCommand(2, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine("--Undo--");
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();

            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine("--Unod--");
            remoteControl.UndoButtonWasPushed(); 
        }
    }
}
