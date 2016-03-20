using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses.ChildClasses
{
    class FairyHead : Head
    {
        //Ctor
        public FairyHead()
        {
            partType = "Fairy";
            image = new Bitmap("Fairy_0.jpg");
        }
    }
}
