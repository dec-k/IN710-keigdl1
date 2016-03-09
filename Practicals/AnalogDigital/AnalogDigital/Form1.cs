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
            //Enable the stop button
            btnStopClock.Enabled = true;
            btnStartClock.Enabled = false;

            //Determine which rdo is checked
            if (rdoDigital.Checked == true)
            {
                //Hide the other clock
                analogClock1.Visible = false;

                //Instantiate a digital clock.
                clock = new DigitalClock(lblDigiTime, timer1);
                clock.Show();
                clock.On();
            }
            else
            {
                //Hide the other clock
                lblDigiTime.Visible = false;

                //Instantiate an Analog clock.
                clock = new AnalogClock(analogClock1, timer1);
                clock.Show();
                clock.On();
            }
        }

        private void btnStopClock_Click(object sender, EventArgs e)
        {
            //Turn off the clocks ticking
            clock.Off();

            //Swap on/off controls
            btnStopClock.Enabled = false;
            btnStartClock.Enabled = true;
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            //Turn off the clocks ticking
            clock.On();

            //Swap on/off controls
            btnStopClock.Enabled = true;
            btnStartClock.Enabled = false;
        }
    }
}
