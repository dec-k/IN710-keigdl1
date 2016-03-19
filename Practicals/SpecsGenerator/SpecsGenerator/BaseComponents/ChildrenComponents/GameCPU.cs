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
            Name = "Intel I5 6600K";
            Price = 599.99;
        }
    }
}
