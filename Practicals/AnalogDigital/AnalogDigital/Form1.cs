using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigital
{
    public partial class Form1 : Form
    {
        //Create an interface type object
        IClock clock;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Update();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            //Enable the pause/start buttons
            btnStopClock.Enabled = true;
            btnStartClock.Enabled = true;

            //Determine which rdo is checked & then instantiate the correct clock.
            if (rdoDigital.Checked == true)
            {
                clock = new DigitalClock(lblDigiTime, timer1);
                clock.Show();
                clock.On();
            }
            else
            {
                clock = new AnalogClock(analogClock1, timer1);
                clock.Show();
                clock.On();
            }
        }
    }
}
