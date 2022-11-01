using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class HeatChecker
    {
        public const double MAX_TEMPERATURE = 80;

        public bool IsOverheated(ITemperatureSensor sensor, DateTime dateTime)
        {
            return sensor.GetTemperature(dateTime) > MAX_TEMPERATURE;
        }
    }
}
