using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.BaseComponents.ChildrenComponents
{
    class GameCPU : CPU
    {
        //Ctor
        public GameCPU()
        {
            name = "Intel i7 5820K";
            price = 799.99;
        }
    }
}
