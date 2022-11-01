using System;

namespace Mediator
{
    public class Alarm
    {
        public void TriggerAlarm()
        {
            Console.WriteLine("Alarm rings");
        }

        public String GetName()
        {
            return "alarm";
        }
    }
}
