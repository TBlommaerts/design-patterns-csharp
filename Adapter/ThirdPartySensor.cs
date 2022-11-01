using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class ThirdPartySensor
    {
        public double FetchTemperature(int year, int month, int day, int hour, int minute, int second, int milliseconds)
        {
            // Dummy value (actual logic should go here instead)
            return 104.0;
        }
    }
}
