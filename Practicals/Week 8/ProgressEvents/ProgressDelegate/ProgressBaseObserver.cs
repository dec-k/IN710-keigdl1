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

            //Fire up a handler
            EventHandler
        }
    }
}
