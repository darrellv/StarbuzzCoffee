using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public class Decaf : Beverage 
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}