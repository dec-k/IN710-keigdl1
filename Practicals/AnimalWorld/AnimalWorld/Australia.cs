using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    class Australia : Continent
    {
        //Ctor
        public Australia(ListBox displayBox, Random rGen, int nAnimalTypes, Graphics canvas)
            : base(displayBox, rGen, nAnimalTypes, canvas)
        {
            //instantiate the appropriate factory
            animalFactory = new AustralianAnimalFactory();
        }
    }
}
