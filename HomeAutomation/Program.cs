// See https://aka.ms/new-console-template for more information

// This is our client

using HomeAutomation;
using HomeAutomation.Commands;
using HomeAutomation.Receivers;

// Invoker
var remote = new SimpleRemoteControl();

// Receiver
var light = new Light();

// Command
var lightOn = new LightOnCommand(light);

remote.SetCommand(lightOn);
remote.ButtonWasPressed();

Console.WriteLine();

var garageDoor = new GarageDoor();
var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

remote.SetCommand(garageDoorOpen);
remote.ButtonWasPressed();

Console.WriteLine();

// meta command pattern (for party mode - puts multiple commands together as one command)
var macroCommand = new MacroCommand([lightOn, garageDoorOpen]);

remote.SetCommand(macroCommand);
remote.ButtonWasPressed();