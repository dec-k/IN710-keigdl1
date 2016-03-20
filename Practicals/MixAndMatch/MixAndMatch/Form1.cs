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
            cbHead.Items.Add("Frankenstein");
            cbHead.Items.Add("Vampire");
            cbHead.Items.Add("Skeleton");
            cbHead.Items.Add("Witch");
            cbHead.Items.Add("Werewolf");

            //Populate body cb
            cbBody.Items.Add("Fairy");
            cbBody.Items.Add("Frankenstein");
            cbBody.Items.Add("Vampire");
            cbBody.Items.Add("Skeleton");
            cbBody.Items.Add("Witch");
            cbBody.Items.Add("Werewolf");

            //Populate Feet cb
            cbFeet.Items.Add("Fairy");
            cbFeet.Items.Add("Frankenstein");
            cbFeet.Items.Add("Vampire");
            cbFeet.Items.Add("Skeleton");
            cbFeet.Items.Add("Witch");
            cbFeet.Items.Add("Werewolf");
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Get selected head & display
            string selectedHead = cbHead.SelectedItem.ToString();
            ModelMaker headModelMaker = makerFactory.createModelMaker(selectedHead);
            pbHead.Image = headModelMaker.headImage();

            //Get selected body & display
            string selectedBody = cbBody.SelectedItem.ToString();
            ModelMaker bodyModelMaker = makerFactory.createModelMaker(selectedBody);
            pbBody.Image = headModelMaker.bodyImage();

            //Get selected legs & display
            string selectedLegs = cbFeet.SelectedItem.ToString();
            ModelMaker legsModelMaker = makerFactory.createModelMaker(selectedLegs);
            pbFeet.Image = legsModelMaker.legsImage();
        }
    }
}
