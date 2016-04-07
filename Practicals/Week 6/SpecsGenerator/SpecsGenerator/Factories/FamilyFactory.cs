using SpecsGenerator.BaseComponents.ChildrenComponents;
using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.Factories
{
    class FamilyFactory : IMachineMaker
    {
        //Create shell of a pc
        CPU newCPU = null;
        GPU newGPU = null;
        RAM newRAM = null;

        public CPU makeCPU()
        {
            newCPU = new FamilyCPU();
            return newCPU;
        }

        public GPU makeGPU()
        {
            newGPU = new FamilyGPU();
            return newGPU;
        }

        public RAM makeRAM()
        {
            newRAM = new FamilyRAM();
            return newRAM;
        }
    }
}
