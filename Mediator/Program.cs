using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new AutomationMediator();

            Alarm alarm = new Alarm();
            Shutter shutter = new Shutter();

            alarm.TriggerAlarm();
            Console.WriteLine();
            shutter.CloseShutter();
        }
    }
}
