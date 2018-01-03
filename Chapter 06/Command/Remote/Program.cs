using System;

namespace Remote
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            #region List<ICommand> 로 구현한 경우
            // var livingRoomLightSlot = remoteControl.AddCommand(livingRoomLightOn, livingRoomLightOff);
            // var kitchenLightSlot = remoteControl.AddCommand(kitchenLightOn, kitchenLightOff);
            // var ceilingFanSlot = remoteControl.AddCommand(ceilingFanOn, ceilingFanOff);
            // var garageDoorSlot = remoteControl.AddCommand(garageDoorUp, garageDoorDown);
            // var stereoSlot = remoteControl.AddCommand(stereoOnWithCD, stereoOff);

            // Console.WriteLine(remoteControl);

            // remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            // remoteControl.OffButtonWasPushed(livingRoomLightSlot);
            // remoteControl.OnButtonWasPushed(kitchenLightSlot);
            // remoteControl.OffButtonWasPushed(kitchenLightSlot);
            // remoteControl.OnButtonWasPushed(ceilingFanSlot);
            // remoteControl.OffButtonWasPushed(ceilingFanSlot);
            // remoteControl.OnButtonWasPushed(garageDoorSlot);
            // remoteControl.OffButtonWasPushed(garageDoorSlot);
            // remoteControl.OnButtonWasPushed(stereoSlot);
            // remoteControl.OffButtonWasPushed(stereoSlot);
            #endregion

            #region ICommand[] 로 구현한 경우
            remoteControl.AddCommand(0,livingRoomLightOn, livingRoomLightOff);
            remoteControl.AddCommand(1,kitchenLightOn, kitchenLightOff);
            remoteControl.AddCommand(2,ceilingFanOn, ceilingFanOff);
            //remoteControl.AddCommand(3,garageDoorUp, garageDoorDown);
            remoteControl.AddCommand(4,stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            #endregion

        }
    }
}
