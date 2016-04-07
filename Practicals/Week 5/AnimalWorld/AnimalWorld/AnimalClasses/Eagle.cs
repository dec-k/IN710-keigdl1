using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Eagle : Animal
    {
        //ctor
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "small animals";
            image = new Bitmap("eagle.jpg");
        }
    }
}
