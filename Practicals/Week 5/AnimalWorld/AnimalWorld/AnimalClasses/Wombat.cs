﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Wombat : Animal
    {
        //ctor
        public Wombat()
        {
            name = "Wombat";
            family = "Herbivore";
            food = "grasses";
            image = new Bitmap("wombat.jpg");
        }
    }
}
