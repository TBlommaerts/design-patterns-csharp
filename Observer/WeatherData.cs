using System;

namespace Observer
{
    public class WeatherData: ISubject
	{
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData()
		{
			// TODO
		}

		public void RegisterObserver(IObserver o)
		{
			// TODO
		}

		public void RemoveObserver(IObserver o)
		{
			// TODO
		}

		public void NotifyObservers()
		{
			// TODO
		}

		public void MeasurementsChanged()
		{
			// TODO
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			// TODO
		}

		public float GetTemperature()
		{
			return temperature;
		}

		public float GetHumidity()
		{
			return humidity;
		}

		public float GetPressure()
		{
			return pressure;
		}
	}
}
