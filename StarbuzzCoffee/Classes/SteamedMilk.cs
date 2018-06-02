using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class SteamedMilk : Beverage
    {
        Beverage beverage;

        public SteamedMilk(Beverage bev)
        {
            beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
