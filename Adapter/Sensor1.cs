using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Sensor1: ITemperatureSensor
    {
        public double GetTemperature(DateTime dateTime)
        {

            // Dummy value (actual logic should go here instead)
            return 42.3;
        }
    }
}
