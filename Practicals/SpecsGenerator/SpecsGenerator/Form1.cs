using SpecsGenerator.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecsGenerator
{
    public partial class Form1 : Form
    {
        //dec machine maker
        IMachineMaker mm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setup print for later use
            SpecPrinter sp;

            //make different pc depending on checked rdobtn
            if (rd1.Checked)
            {
                mm = new GameFactory();
            }
            else if (rd2.Checked)
            {
                mm = new FamilyFactory();
            }
            else if (rd3.Checked)
            {
                mm = new MediaFactory();
            }
            else if (rd4.Checked)
            {
                mm = new LaptopFactory();
            }

            //use printer to output above data to lb
            sp = new SpecPrinter(mm, listBox1);
            sp.print();
        }
    }
}
