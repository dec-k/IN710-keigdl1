using MixAndMatch.MixableClasses;
using MixAndMatch.MixableClasses.ChildClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class CharacterMaker : Form
    {
        //Declare a character maker & printer
        ICharMaker cm;
        Printer prntr;

        public CharacterMaker()
        {
            InitializeComponent();

            //Populate head cb
            cbHead.Items.Add(new FairyHead().ToString());

            //Populate body cb
            cbHead.Items.Add(new FairyBody().ToString());

            //Populate Feet cb
            cbHead.Items.Add(new FairyLegs().ToString());
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Logic here is to pass the currently selected item's in the comboBox into
            //an instance of the Builder class
        }
    }
}
