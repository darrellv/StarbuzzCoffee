using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Classes
{
    public abstract class Beverage
    {
        protected enum Size
        {
            TALL,
            GRANDE,
            VENTI
        }
        protected Size BeverageSize { get; set; }

        

        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();

    }
}
