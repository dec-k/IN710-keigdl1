using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressDelegate
{
   public class ProgressSubject
    {
       //Declare an event
       public event EventHandler<CustomEventArgs> progressEvent;

       //Blank ctor
       public ProgressSubject(){ }


       public void SlowMethod(NumericUpDown nud, ProgressBar progBar, TrackBar trackBar)
       {
           for (int i = 0; i < 10; i++)
           {
               System.Threading.Thread.Sleep(500);
               OnUpdateEvent(nud,progBar,trackBar);
           }
       }

       //The reason this one takes multiple arguments is so it can field any relevant argument this prac can give.
       //It deviates from the one specified slightly but I couldn't think of how to do this without args as was shown in the handout. Discuss?
       private void OnUpdateEvent(NumericUpDown nud, ProgressBar progBar, TrackBar trackBar)
       {
           //Create a new custom event arg 
           CustomEventArgs ce = new CustomEventArgs(nud, progBar, trackBar);

           //A bit of error-prevention as discussed in class
           if (progressEvent != null)
           {
               progressEvent(this, ce);
           }
       }
   }
}
