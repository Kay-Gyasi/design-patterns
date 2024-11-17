namespace HomeAutomation;

public interface ICommand
{
    void Execute();
    void Undo(); // additional functionality
}