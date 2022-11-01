using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();

			CurrentConditionsDisplay currentDisplay =
				new CurrentConditionsDisplay(weatherData);
			StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

			weatherData.SetMeasurements(80, 65, 30.4f);
			weatherData.SetMeasurements(82, 70, 29.2f);
			weatherData.SetMeasurements(78, 90, 29.2f);

			weatherData.RemoveObserver(currentDisplay);
			weatherData.RemoveObserver(statisticsDisplay);
			weatherData.SetMeasurements(78, 90, 29.2f);
		}
    }
}
