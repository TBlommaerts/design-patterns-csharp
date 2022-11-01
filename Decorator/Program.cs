using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            coffee.SetMilk(true);
            coffee.SetSoy(true);

            Console.WriteLine("Price coffee: " + coffee.Cost());
        }
    }
}
