using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.ComponentClasses
{
    class CPU
    {
        //Attr
        private string name;
        private double price;

        //Accessors
        protected double Price
        {
            get { return price; }
            set { price = value; }
        }
        protected string Name
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
