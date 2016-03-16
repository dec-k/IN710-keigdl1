using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Bison : Animal
    {
        //ctor
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "grass";
            image = new Bitmap("bison.jpg");
        }
    }
}
