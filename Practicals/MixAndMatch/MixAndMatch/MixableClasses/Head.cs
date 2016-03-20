using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses
{
    class Head
    {
        //Attributes
        protected string partType;
        protected Bitmap image;

        //Accessors
        public Bitmap Image
        {
            get { return image; }
        }
        protected string PartType
        {
            get { return partType; }
            set { partType = value; }
        }

        //ToString override
        public override string ToString()
        {
            return partType;
        }
    }
}
