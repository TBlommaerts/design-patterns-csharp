using System;

namespace Mediator
{
    public class CoffeeMachine
    {
        public void BrewCoffee()
        {
            Console.WriteLine("Coffee starts brewing");
        }

        public String GetName()
        {
            return "coffee_machine";
        }
    }
}
