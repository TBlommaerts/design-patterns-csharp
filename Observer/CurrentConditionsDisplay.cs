using System;

namespace Observer
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
		private float temperature;
		private float humidity;

		public CurrentConditionsDisplay(WeatherData weatherData)
		{
			// TODO
		}

		public void Update(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			Display();
		}

		public void Display()
		{
			Console.Write("Current conditions: " + temperature
				+ "F degrees and " + humidity + "% humidity");
		}
	}
}
