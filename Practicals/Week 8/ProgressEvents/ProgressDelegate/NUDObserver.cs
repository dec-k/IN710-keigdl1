using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressDelegate
{
    class NUDObserver : ProgressBaseObserver
    {
        //ctor
        public NUDObserver(ProgressSubject subject) : base(subject) { }
        public override void ProgUpdateHandler(object subject, CustomEventArgs ce)
        {
            ce.nud.UpButton();
            ce.nud.Refresh();
        }
    }
}
