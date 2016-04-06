using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressDelegate
{
    public abstract class ProgressBaseObserver
    {
        //Attr
        protected ProgressSubject subject;

        //Ctor
        public ProgressBaseObserver(ProgressSubject subject)
        {
            this.subject = subject;

            //Fire up a handler like last practical except with a custom handler class
            EventHandler<CustomEventArgs> handler = new EventHandler<CustomEventArgs>(ProgUpdateHandler);
        }

        //Abstract method that all child observers will provide implementation for
        public abstract void ProgUpdateHandler(object subject, CustomEventArgs ce)
        {

        }
    }
}
