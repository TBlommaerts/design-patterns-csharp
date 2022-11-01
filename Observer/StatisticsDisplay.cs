using System;

namespace Observer
{
    public class StatisticsDisplay: IObserver, IDisplayElement
    {
		private float maxTemp = 0.0f;
		private float minTemp = 200;
		private float tempSum = 0.0f;
		private int numReadings;

		public StatisticsDisplay(WeatherData weatherData)
		{
			// TODO
		}

		public void Update(float temp, float humidity, float pressure)
		{
			tempSum += temp;
			numReadings++;

			if (temp > maxTemp)
			{
				maxTemp = temp;
			}

			if (temp < minTemp)
			{
				minTemp = temp;
			}

			Display();
		}

		public void Display()
		{
			Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
				+ "/" + maxTemp + "/" + minTemp);
		}
	}
}
