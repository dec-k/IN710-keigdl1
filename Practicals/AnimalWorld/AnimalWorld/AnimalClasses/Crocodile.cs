using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Crocodile : Animal
    {
        //ctor
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "the flesh of my enemies";
            image = new Bitmap("crocodile.jpg");
        }
    }
}
