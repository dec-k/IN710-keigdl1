using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This button is just for debugging simple stuff and will be removed later.

            Character tootie = new Knight("Seigmeyer of Catarina");
            listBox2.Items.Add(tootie.outputName());
            listBox2.Items.Add(tootie.outputType());
            listBox2.Items.Add(tootie.useCharactersWeapon());

            Character frooty = new Bandit("Mild-Mannered Pate");
            listBox2.Items.Add(frooty.outputName());
            listBox2.Items.Add(frooty.outputType());
            listBox2.Items.Add(frooty.useCharactersWeapon());
        }
    }
}
