using SpecsGenerator.BaseComponents.ChildrenComponents;
using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.Factories
{
    class MediaFactory : IMachineMaker
    {
        //Create shell of a pc
        CPU newCPU = null;
        GPU newGPU = null;
        RAM newRAM = null;

        public CPU makeCPU()
        {
            newCPU = new MediaCPU();
            return newCPU;
        }

        public GPU makeGPU()
        {
            newGPU = new MediaGPU();
            return newGPU;
        }

        public RAM makeRAM()
        {
            newRAM = new MediaRAM();
            return newRAM;
        }
    }
}
