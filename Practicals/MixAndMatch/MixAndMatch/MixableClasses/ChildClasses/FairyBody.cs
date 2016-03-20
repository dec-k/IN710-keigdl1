﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses.ChildClasses
{
    class FairyBody : Body
    {
        //Ctor
        public FairyBody()
        {
            partType = "Fairy";
            image = new Bitmap("Fairy_1.png");
        }
    }
}