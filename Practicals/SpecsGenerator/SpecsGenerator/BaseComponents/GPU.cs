using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator
{
    class GPU
    {
        //Attr
        protected string name;
        protected double price;

        //Methods
        public override string ToString()
        {
            return "$" + price + ", " + name;
        }

    }
}
