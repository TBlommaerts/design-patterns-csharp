using System;

namespace Decorator
{
    public class Coffee: Beverage
    {        
        public override double Cost()
        {
            return 2.99 + base.Cost();
        }
    }
}
