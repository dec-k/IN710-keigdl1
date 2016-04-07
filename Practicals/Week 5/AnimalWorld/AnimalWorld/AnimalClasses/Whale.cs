using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Whale : Animal
    {
        //ctor
        public Whale()
        {
            name = "Whale";
            family = "Carnivore";
            food = "Krill";
            //I mean, you really just see the fin on the form.
            //But the whale is there in spirit! Right?
            image = new Bitmap("whale.jpeg");
        }
    }
}
