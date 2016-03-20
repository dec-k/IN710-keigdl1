using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.BaseComponents.ChildrenComponents
{
    class LaptopCPU : CPU
    {
        //Ctor
        public LaptopCPU()
        {
            Name = "Intel i7 4960 HQ";
            Price = 623.00;
        }
    }
}
