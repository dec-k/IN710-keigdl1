﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Wolf : Animal
    {
        //ctor
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "small animals";
            image = new Bitmap("wolf.jpg");
        }
    }
}
