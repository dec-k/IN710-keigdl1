using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Koala : Animal
    {
        //ctor
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Eucalyptus leaves";
            image = new Bitmap("koala.jpg");
        }
    }
}
