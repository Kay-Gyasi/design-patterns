namespace Weather_O_Rama.Observers;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private ISubject? Subject { get; set; }
    private float Temperature { get; set; }
    private float Humidity { get; set; }

    public CurrentConditionsDisplay(ISubject subject)
    {
        Subject = subject;
        Subject.RegisterObserver(this);
    }

    /// <summary>
    /// This is the PUSH model of the Observer pattern
    /// </summary>
    /// <param name="message"></param>
    public void Update(Message message)
    {
        Console.WriteLine("CurrentConditionsDisplay received an update");

        Temperature = message.Temperature;
        Humidity = message.Humidity;
        Display();
    }

    /// <summary>
    /// This is the PULL model of the Observer pattern
    /// </summary>
    public void Update()
    {
        Console.WriteLine("CurrentConditionsDisplay received an update");

        if (Subject is null)
        {
            throw new InvalidOperationException("Subject is not set");
        }

        Temperature = Subject.GetTemperature();
        Humidity = Subject.GetHumidity();
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
    }
}