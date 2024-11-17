namespace HomeAutomation.Commands;

// Meta Command Pattern
public class MacroCommand(ICommand[] commands) : ICommand
{
    private ICommand[] Commands { get; } = commands;

    public void Execute()
    {
        Console.WriteLine("Executing meta commands");

        foreach (var command in Commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in Commands)
        {
            command.Undo();
        }
    }
}