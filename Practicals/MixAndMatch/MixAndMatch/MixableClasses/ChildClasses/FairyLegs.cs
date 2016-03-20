using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses.ChildClasses
{
    class FairyLegs : Legs
    {
        //Ctor
        public FairyLegs()
        {
            partType = "Fairy";
            image = new Bitmap("Fairy_2.png");
        }
    }
}
