using HomeAutomation.Receivers;

namespace HomeAutomation.Commands;

public class LightOnCommand(ILight light) : ICommand
{
    private ILight Light { get; } = light;

    public void Execute()
    {
        Light.On();
    }

    public void Undo()
    {
        Light.Off();
    }
}

public class LightOffCommand(ILight light) : ICommand
{
    public ILight Light { get; } = light;

    public void Execute()
    {
        Light.Off();
    }

    public void Undo()
    {
        Light.On();
    }
}