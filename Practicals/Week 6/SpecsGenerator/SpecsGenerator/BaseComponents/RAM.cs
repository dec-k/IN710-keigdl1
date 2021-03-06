﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.ComponentClasses
{
    class RAM
    {
        //Attr
        protected string name;
        protected double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Methods
        public override string ToString()
        {
            return "$" + price + ", " + name;
        }
    }
}
