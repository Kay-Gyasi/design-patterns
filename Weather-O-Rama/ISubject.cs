namespace Weather_O_Rama;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(Message message);

    #region PULL methods

    float GetTemperature();
    float GetHumidity();
    float GetPressure();

    #endregion
}