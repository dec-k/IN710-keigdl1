using MixAndMatch.Factories;
using MixAndMatch.MixableClasses;
using MixAndMatch.MixableClasses.ChildClasses;
using MixAndMatch.Models;
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
        ICharacterMaker makerFactory;

        public CharacterMaker()
        {
            InitializeComponent();

            //Instantiate makerFactory
            makerFactory = new MakerFactory();

            //Populate head cb
            cbHead.Items.Add("Fairy");

            //Populate body cb
            cbBody.Items.Add("Fairy");

            //Populate Feet cb
            cbFeet.Items.Add("Fairy");
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Get selected head
            string selectedHead = cbHead.SelectedItem.ToString();
            ModelMaker headModelMaker = makerFactory.createModelMaker(selectedHead);

            //Display head
            pbHead.Image = headModelMaker.headImage();

            
        }
    }
}
