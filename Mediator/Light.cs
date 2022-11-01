using System;

namespace Mediator
{
    public class Light
    {
        public void TurnOnLight()
        {
            Console.WriteLine("Light turns on");
        }

        public String GetName()
        {
            return "light";
        }
    }
}
