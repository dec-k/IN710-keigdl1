using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    //I read and digested this link:
    //https://msdn.microsoft.com/en-us/library/ms171728(v=vs.110).aspx

    //Declare a delegate for form controlling. You can also make this in each method
    //but it just saves precious keystrokes to do it here.
    delegate void FormControllerDelegate(metronomeEventArgs e);

    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            //The InvokeRequired method will compares the ID of the thread that
            //CALLED this event, to the one that MADE this event.
            //If they are different, invoke required returns TRUE.
            if (spinBox.InvokeRequired)
            {
                //Create delegate instance and provide it an update method
                FormControllerDelegate fcd = new FormControllerDelegate(incrementSpinner);

                //Invoke method asynchronously via a callback method.
                spinBox.Invoke(fcd, new object[] { e });
            }
            else
            {
                spinBox.Value++;
            }
                
        }

        private void incrementSpinner(metronomeEventArgs e)
        {
            spinBox.Value++;
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            DateTime currDateTime = e.currentTime;
            listBox.Items.Add(currDateTime.ToString());         
        }
    }        
}
