using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressDelegate
{
    public partial class Form1 : Form
    {
        //Declare a slowWorker subject
        ProgressSubject slowWorker;

        //Declare 3 new observers, one for each type of control
        ProgBarObserver progBarObs;
        TrackBarObserver trackBarObs;
        NUDObserver nudObs;

        public Form1()
        {
            InitializeComponent();

            //init new observers
            slowWorker = new ProgressSubject();

            //intantiate these new observers and pass them the subject so they know who to 'listen' on.
            progBarObs = new ProgBarObserver(slowWorker);
            trackBarObs = new TrackBarObserver(slowWorker);
            nudObs = new NUDObserver(slowWorker);
        }

        private void btnTestProgress_Click(object sender, EventArgs e)
        {
            //reset progress-guys values
            resetProgressIndicators();

            //call slowworker
            slowWorker.SlowMethod(nudTest,progTest,trackTest);
        }

        private void resetProgressIndicators()
        {
            progTest.Value = 0;
            nudTest.Value = 0;
            trackTest.Value = 0;
        }
    }
}
