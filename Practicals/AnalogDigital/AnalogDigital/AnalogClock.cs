using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigital
{
    class AnalogClock : IClock
    {
        //Note Here: AnalogClock was a bad class name, it is ambiguous as AnalogClockControl uses the same name for its clock object.
        //Attr
        Timer timer;
        AnalogClockControl.AnalogClock clock;

        //Ctor
        public AnalogClock(AnalogClockControl.AnalogClock clock, Timer timer){
            this.timer = timer;
            this.clock = clock;
        }

        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
