using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        //Attr
        List<PictureBox> pictureBoxList;

        //Ctor
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            //This version of the method only updates the image boxes.
            for (int i = 0; i < critterList.Count; i++)
            {
                pictureBoxList[i].Image = Image.FromFile(critterList[i].ImageFileName);
            }
        }

        public void clearDisplay()
        {
            //This version of the method clears the pb's
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                pictureBoxList[i].Image = null;
            }
        }
    }
}
