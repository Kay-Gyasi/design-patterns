namespace HomeAutomation.Receivers;

public interface IGarageDoor
{
    void Up();
    void Down();
    void Stop();
    void LightOn();
    void LightOff();
}

// This is a receiver
public class GarageDoor : IGarageDoor
{
    public void Up()
    {
        Console.WriteLine("Garage door is up");
    }

    public void Down()
    {
        Console.WriteLine("Garage door is down");
    }

    public void Stop()
    {
        Console.WriteLine("Garage door is stopped");
    }

    public void LightOn()
    {
        Console.WriteLine("Garage light is on");
    }

    public void LightOff()
    {
        Console.WriteLine("Garage light is off");
    }
}