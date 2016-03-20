using MixAndMatch.MixableClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    class Printer
    {
        //Declare a charmaker
        ICharMaker cm;
        PictureBox pb1;
        PictureBox pb2;
        PictureBox pb3;

        //Ctor that receives a charmaker and 3 pictureboxes
        public Printer(ICharMaker cm, PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            this.cm = cm;
            this.pb1 = pb1;
            this.pb2 = pb2;
            this.pb3 = pb3;
        }

        //Methods to output the creature to the form
        public void ShowHead()
        {

        }
        public void ShowBody()
        {

        }
        public void ShowFeet()
        {

        }


    }
}
