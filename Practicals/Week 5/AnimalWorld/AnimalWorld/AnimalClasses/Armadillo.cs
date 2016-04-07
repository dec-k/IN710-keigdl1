using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Armadillo : Animal
    {
        //ctor
        public Armadillo()
        {
            name = "Armadillo";
            family = "Omnivore";
            food = "Insects & Plants";
            image = new Bitmap("armadillo.jpg");
        }
    }
}
