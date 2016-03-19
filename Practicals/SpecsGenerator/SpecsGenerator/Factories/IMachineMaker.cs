using SpecsGenerator.ComponentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator
{
    interface IMachineMaker
    {
        CPU makeCPU();
        GPU makeGPU();
        RAM makeRAM();
    }
}
