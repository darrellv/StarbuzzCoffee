using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class Whip : Beverage
    {
        Beverage beverage;

        public Whip(Beverage bev)
        {
            beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
