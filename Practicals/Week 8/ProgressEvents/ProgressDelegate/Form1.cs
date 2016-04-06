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
        //Setup a Delegate type
        public delegate void delegateProgressType();
        //make an instance of the delegate accessible to the form
        delegateProgressType dpt;

        //Declare a slowWorker subject
        ProgressSubject slowWorker;

        //Declare 3 new observers, one for each type of control
        ProgBarObserver progBarObs;
        TrackBarObserver trackBarObs;
        NUDObserver nudObs;

        public Form1()
        {
            InitializeComponent();
            //check a default option
            rdoSpinner.Checked = true;

            //init new observers
            slowWorker = new ProgressSubject();

            //intantiate these new observers and pass them the subject so they know who to 'listen' on.
            progBarObs = new ProgBarObserver(slowWorker);
            trackBarObs = new TrackBarObserver(slowWorker);
            nudObs = new NUDObserver(slowWorker);
        }

        //Increment spinner val
        private void increaseSpinner()
        {
            Application.DoEvents();
            nudTest.Value++;
        }

        //Increment progress bar
        private void increaseProgBar()
        {
            progTest.Value++;
        }

        //Increment track bar
        private void increaseTrackBar()
        {
            trackTest.Value++;
        }

        //Artificially slow down progress
        private void slowMethod(delegateProgressType delegateProgressType)
        {
            //Sleep 10 times to simulate progress
            for (int i = 0; i < 10; i++)
            {
                //Sleep 1s
                Thread.Sleep(1000);
                //Run the function bound to the passed in delegate instance
                delegateProgressType();
            }
        }

        private void btnTestProgress_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod(nudTest,progTest,trackTest);

            //7.2 CODE WILL COMMENT OUT LATER
            /*reset the progress bars to prevent them causing out of bounds errors
            resetProgressIndicators();

            //determine which button checked
            if (rdoSpinner.Checked)
            {
                dpt = new delegateProgressType(increaseSpinner);
            }
            else if (rdoProgressBar.Checked)
            {
                dpt = new delegateProgressType(increaseProgBar);
            }
            else if (rdoTrackbar.Checked)
            {
                dpt = new delegateProgressType(increaseTrackBar);
            }

            //pass slow method the delegate we just defined
            slowMethod(dpt);
             */
        }

        private void resetProgressIndicators()
        {
            progTest.Value = 0;
            nudTest.Value = 0;
            trackTest.Value = 0;
        }
    }
}
