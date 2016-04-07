using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.BaseComponents.ChildrenComponents
{
    class FamilyCPU : CPU
    {
        //Ctor
        public FamilyCPU()
        {
            Name = "AMD FX 4350";
            Price = 179.99;
        }
    }
}
