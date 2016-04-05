using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserverBase
    {
        //Attr
        FireAlarmSubject subject;

        //Ctor
        public FireAlarmObserverBase(FireAlarmSubject s)
        {
            subject = s;
            //Create an event handler
            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmEventHandler);
 
            //Bind this subject's method to a event handler
            subject.FireEvent += handler;
        }

        //Abstract method
        public abstract void FireAlarmEventHandler(object fireSubject, FireAlarmEventArgs fe);
    }
}
