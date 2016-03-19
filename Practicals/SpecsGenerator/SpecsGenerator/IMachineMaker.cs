using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator
{
    interface IMachineMaker
    {
        private void makeCPU();
        private void makeGPU();
        private void makeRAM();
    }
}
