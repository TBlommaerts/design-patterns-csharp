using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
		{
			/*
			 * We have an application that is able to measure the heat on mechanical components based on sensor data.
			 * Currently, our company produces 2 types of sensors, which both measure the temperature in degrees Celsius.
			 */
			ITemperatureSensor sensor1 = new Sensor1();
			ITemperatureSensor sensor2 = new Sensor2();

			HeatChecker heatChecker = new HeatChecker();

			var timeToCheck = new DateTime(2022, 10, 30, 15, 52, 43, 452);

			var sensor1Overheated = heatChecker.IsOverheated(sensor1, timeToCheck);
			var sensor2Overheated = heatChecker.IsOverheated(sensor2, timeToCheck);

			Console.WriteLine("Sensor 1 was overheated on " + timeToCheck.ToString() + " : " + sensor1Overheated + ".");
			Console.WriteLine("Sensor 2 was overheated on " + timeToCheck.ToString() + " : " + sensor2Overheated + ".");

			/*
			 *  We also want to support the use of third party sensors.
			 *  The sensor below is defined in an external library, which we don't have control over.
			 *  It comes from an American manufacturer, so everything is measure in degrees Fahrenheit
			 */
			ThirdPartySensor sensor3 = new ThirdPartySensor();

			// TODO Write an adapter for this sensor, so we can use it with our existing interfaces in our application.
		}
	}
}
