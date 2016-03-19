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
            name = "AMD FX 4350";
            price = 179.99;
        }
    }
}
