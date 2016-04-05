using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class FireAlarmSubject
    {
        //Declare a delegate type, this one is used to handle fire events
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs fe);
        //Declare an event 'listener' of the same type as the delegate
        public event FireEventHandler FireEvent;

        public void OnFireEvent(EFireCategory fireCategory)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(fireCategory);

            //Check to make sure event cannot be triggered while event contains null data
            if(FireEvent != null){
                //Call fire event, giving it itself as an object argument and the passed-in fire severity as an argument.
                FireEvent(this,fe);
            }
        }
    }
}
