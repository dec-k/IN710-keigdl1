using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses
{
    class ModelMaker
    {
        //Attributes
        protected string charLabel;

        //blank ctor
        public ModelMaker()
        {

        }

        //Methods to get image filenames for each part of the creature.
        public Bitmap headImage()
        {
            return new Bitmap(charLabel + "_0.png");
        }
        public Bitmap bodyImage()
        {
            return new Bitmap(charLabel + "_1.png");
        }
        public Bitmap legsImage()
        {
            return new Bitmap(charLabel + "_2.png");
        }
    }
}
