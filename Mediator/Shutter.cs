using System;

namespace Mediator
{
    public class Shutter
    {
        public void OpenShutter()
        {
            Console.WriteLine("Shutter opens");
        }

        public void CloseShutter()
        {
            Console.WriteLine("Shutter closes");
        }

        public String GetName()
        {
            return "shutter";
        }
    }
}
