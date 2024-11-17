namespace HomeAutomation.Receivers;

public interface ILight
{
    void On();
    void Off();
}

// This is a receiver
public class Light : ILight
{
    public void On()
    {
        Console.WriteLine("Light is on");
    }

    public void Off()
    {
        Console.WriteLine("Light is off");
    }
}