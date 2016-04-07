using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikesSubObs
{
    public partial class Form1 : Form
    {
        //declare obs
        Subject subject;
        RPMObserver rpmOb;
        CalObserver calOb;
        KMObserver kmOb;

        public Form1()
        {
            InitializeComponent();

            //declare& instantiate sub
            subject = new Subject();

            //instantiate obs
            rpmOb = new RPMObserver(lbRPM, subject);
            calOb = new CalObserver(lbCal, subject);
            kmOb = new KMObserver(lbKM, subject);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //read from textbox
            int currentSpeed = Int32.Parse(txtSpeed.Text);

            subject.CurrentRPM = currentSpeed;
            subject.NotifyObservers();

  
        }
    }
}
