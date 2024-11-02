// See https://aka.ms/new-console-template for more information

using Weather_O_Rama;
using Weather_O_Rama.Observers;

var weatherData = new WeatherData();

var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);

weatherData.ResetMeasurements();

Console.ReadKey();

weatherData.RemoveObserver(currentConditionsDisplay);

weatherData.ResetMeasurements();

Console.ReadKey();

weatherData.RemoveObserver(statisticsDisplay);

weatherData.ResetMeasurements();

Console.ReadKey();

weatherData.RegisterObserver(statisticsDisplay);

weatherData.ResetMeasurements();

Console.ReadKey();