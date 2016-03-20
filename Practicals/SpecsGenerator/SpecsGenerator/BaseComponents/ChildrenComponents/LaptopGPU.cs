using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecsGenerator.BaseComponents.ChildrenComponents
{
    class LaptopGPU : GPU
    {
        public LaptopGPU(){
            name = "NVIDIA GTX 980 SLI";
            price = 799.99;
        }
    }
}
