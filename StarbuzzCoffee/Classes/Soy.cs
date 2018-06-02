using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class Soy : Beverage 
    {
        Beverage beverage;

        public Soy(Beverage bev)
        {
            beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + .15;
        }
    }
}
