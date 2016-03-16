﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Seal : Animal
    {
        //ctor
        public Seal()
        {
            name = "Seal";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("seal.jpg");
        }
    }
}
