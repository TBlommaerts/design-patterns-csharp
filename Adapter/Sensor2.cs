using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Sensor2: ITemperatureSensor
    {
        public double GetTemperature(DateTime dateTime)
        {

            // Dummy value (actual logic should go here instead)
            return 89.82;
        }
    }
}
