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

            //Create a handler and bind it to the specified method
            EventHandler<CustomEventArgs> handler = new EventHandler<CustomEventArgs>(ProgUpdateHandler);

            //Bind the handler to a subject
            subject.progressEvent += handler;
        }

        //Abstract method that all child observers will provide implementation for
        public abstract void ProgUpdateHandler(object subject, CustomEventArgs ce);
    }
}
