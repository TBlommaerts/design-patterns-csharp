using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface ITemperatureSensor
    {
        public double GetTemperature(DateTime dateTime);
    }
}
