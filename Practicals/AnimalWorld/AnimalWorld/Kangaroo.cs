using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Kangaroo : Animal
    {
        //Pretend there are a ton of kangaroo-specific fields here.
        //int pouchWidth;
        //int pouchHeight;
        //float fightWinRatio;

        //ctor
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("kangaroo.jpg");
        }
    }
}
