using HomeAutomation.Receivers;

namespace HomeAutomation.Commands;

public class GarageDoorOpenCommand(IGarageDoor garageDoor) : ICommand
{
    private IGarageDoor GarageDoor { get; } = garageDoor;

    public void Execute()
    {
        GarageDoor.Up();
    }

    public void Undo()
    {
        GarageDoor.Down();
    }
}