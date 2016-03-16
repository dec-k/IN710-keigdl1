using AnimalWorld.AnimalWorld;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {
        //Create values needed for constructors
        Random rGen = new Random();
        Canvas canvas = new Canvas();

        //Pretend this constant is in a config file somewhere
        const int ANIMAL_TYPE_COUNT = 3;

        //Declare continents
        Continent na;
        Continent au;

        public Form1()
        {
            InitializeComponent();

            //Instantiate continents
            na = new NorthAmerica(lbDisplayBox, rGen, ANIMAL_TYPE_COUNT, canvas);
            au = new Australia(lbDisplayBox, rGen, ANIMAL_TYPE_COUNT, canvas);
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            au.runSim();
        }

        private void btnNA_Click(object sender, EventArgs e)
        {
            na.runSim();
        }
    }
}
