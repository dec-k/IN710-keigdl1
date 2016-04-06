using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressDelegate
{
    public class CustomEventArgs
    {
        //Create getsets for the different control types
        public NumericUpDown nud { get; set; }
        public ProgressBar progBar { get; set; }
        public TrackBar trackBar { get; set; }

        //Ctor
        //Doesn't do much, just binds args to a local var
        public CustomEventArgs(NumericUpDown nud, ProgressBar progBar, TrackBar trackBar){
            this.nud = nud;
            this.progBar = progBar;
            this.trackBar = trackBar;
        }
    }
}
