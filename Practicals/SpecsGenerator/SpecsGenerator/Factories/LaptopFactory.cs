using SpecsGenerator.BaseComponents.ChildrenComponents;
using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.Factories
{
    class LaptopFactory : IMachineMaker
    {
        //Create shell of a pc
        CPU newCPU = null;
        GPU newGPU = null;
        RAM newRAM = null;

        public CPU makeCPU()
        {
            newCPU = new LaptopCPU();
            return newCPU;
        }

        public GPU makeGPU()
        {
            newGPU = new LaptopGPU();
            return newGPU;
        }

        public RAM makeRAM()
        {
            newRAM = new LaptopRAM();
            return newRAM;
        }
    }
}
