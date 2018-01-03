using System;
using System.Collections.Generic;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub huttub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(huttub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(huttub);

            List<ICommand> partyOn = new List<ICommand>{
                lightOn, stereoOn, tvOn, hottubOn
            };
            List<ICommand> partyOff = new List<ICommand>{
                lightOff, stereoOff, tvOff, hottubOff
            };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.AddCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On ---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("\n--- Pushing Macro Off ---");
            remoteControl.OffButtonWasPushed(0);
        }
    }
}
