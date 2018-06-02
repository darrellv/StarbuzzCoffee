using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class Expresso : Beverage 
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
