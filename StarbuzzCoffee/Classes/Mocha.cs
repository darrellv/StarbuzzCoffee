using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class Mocha : Beverage
    {
        Beverage beverage;

        public Mocha(Beverage bev)
        {
            beverage = bev;
            
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
