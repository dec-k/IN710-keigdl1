using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressDelegate
{
    class ProgBarObserver : ProgressBaseObserver
    {
        //Blank ctor
        public ProgBarObserver(ProgressSubject subject) : base(subject) { }

        //override abstract
        public override void ProgUpdateHandler(object subject, CustomEventArgs ce)
        {
            ce.progBar.Value++;
        }
    }
}
