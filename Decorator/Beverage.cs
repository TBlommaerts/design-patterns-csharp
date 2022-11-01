using System;

namespace Decorator
{
    public abstract class Beverage
    {
        private bool milk;
        private bool soy;

        public bool HasMilk()
        {
            return milk;
        }

        public void SetMilk(bool milk)
        {
            this.milk = milk;
        }

        public bool HasSoy()
        {
            return soy;
        }

        public void SetSoy(bool soy)
        {
            this.soy = soy;
        }

        public virtual double Cost()
        {
            double cost = 0;
            if (HasMilk())
            {
                cost += 0.5;
            }
            if (HasSoy())
            {
                cost += 0.75;
            }
            return cost;
        }
    }
}
