using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressDelegate
{
    class TrackBarObserver : ProgressBaseObserver
    {
        //ctor
        public TrackBarObserver(ProgressSubject subject) : base(subject) { }

        public override void ProgUpdateHandler(object subject, CustomEventArgs ce)
        {
            ce.trackBar.Value++;
        }
    }
}
