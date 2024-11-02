namespace Weather_O_Rama.Observers;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private ISubject? Subject { get; set; }
    private List<float> Temperatures { get; } = [];
    private List<float> Pressures { get; }= [];

    public StatisticsDisplay(ISubject subject)
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
        Console.WriteLine("StatisticsDisplay received an update");

        Temperatures.Add(message.Temperature);
        Pressures.Add(message.Pressure);
        Display();
    }

    /// <summary>
    /// This is the PULL model of the Observer pattern
    /// </summary>
    public void Update()
    {
        Console.WriteLine("StatisticsDisplay received an update");

        if (Subject is null)
        {
            throw new InvalidOperationException("Subject is not set");
        }

        Temperatures.Add(Subject.GetTemperature());
        Pressures.Add(Subject.GetPressure());
        Display();
    }

    public void Display()
    {
        var avgTemperature = Temperatures.Average();
        var avgHumidity = Pressures.Average();

        var maxTemperature = Temperatures.Max();
        var maxHumidity = Pressures.Max();

        var minTemperature = Temperatures.Min();
        var minHumidity = Pressures.Min();

        Console.WriteLine("Avg/Max/Min temperature: " + avgTemperature + "/" + maxTemperature + "/" + minTemperature);
        Console.WriteLine("Avg/Max/Min pressure: " + avgHumidity + "/" + maxHumidity + "/" + minHumidity);
    }
}