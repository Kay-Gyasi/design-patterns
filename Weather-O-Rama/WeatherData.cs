using System.Collections.Concurrent;

namespace Weather_O_Rama;

public class WeatherData : ISubject
{
    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }
    private ConcurrentBag<IObserver> Observers { get; } = [];

    public void ResetMeasurements()
    {
        Temperature = ResetTemperature();
        Humidity = ResetHumidity();
        Pressure = ResetPressure();
        MeasurementsChanged();
    }

    private void MeasurementsChanged()
    {
        NotifyObservers(new Message
        {
            Temperature = Temperature,
            Humidity = Humidity,
            Pressure = Pressure
        });
    }

    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine("Adding observer");
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Console.WriteLine("Removing observer");
        _ = Observers.TryTake(out observer!);
    }

    public void NotifyObservers(Message message)
    {
        foreach (var observer in Observers)
        {
            //observer.Update(message);
            observer.Update();
        }
    }

    public float GetTemperature() => Temperature;
    public float GetHumidity() => Humidity;
    public float GetPressure() => Pressure;

    private static float ResetTemperature()
    {
        // Code to be added
        return new Random().NextInt64();
    }

    private static float ResetHumidity()
    {
        // Code to be added
        return new Random().NextInt64();
    }

    private static float ResetPressure()
    {
        // Code to be added
        return new Random().NextInt64();
    }
}