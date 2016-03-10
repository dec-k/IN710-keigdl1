using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        //attr
        ListBox lbOut;

        //Ctor
        public TextDisplay(ListBox lbOut)
        {
            this.lbOut = lbOut;
        }
        
        public void displayCritterList(List<Critter> critterList)
        {
            //This version of the method adds all the critters to the listbox
            for (int i = 0; i < critterList.Count; i++)
            {
                lbOut.Items.Add(critterList[i].Name + ", " + critterList[i].Species);
            }
        }

        public void clearDisplay()
        {
            //Clears the lb's
            lbOut.Items.Clear();
        }
    }
}
