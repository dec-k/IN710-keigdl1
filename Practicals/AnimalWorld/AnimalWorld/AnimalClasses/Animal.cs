using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Animal
    {
        //Animal base class
        protected string name;
        protected string family;
        protected string food;
        protected Bitmap image;
        public Bitmap Image
        {
            get { return image; }
        }

        //Override toString
        public override string ToString()
        {
            //build output string
            string displayText = "I am a " + name;
            displayText += ". I'm a " + family;
            displayText += ". I eat " + food + ".";

            //ret
            return displayText;
        }
    }
}
