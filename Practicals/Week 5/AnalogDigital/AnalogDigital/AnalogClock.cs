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
            clock.Start();
        }

        public void Off()
        {
            clock.Stop();
        }

        public void Update()
        {
            //AnalogClockControl doesn't rely on a timer to update, it can just be handled
            //with On/off controls so this one feels redundant.
        }

        public void Show()
        {
            clock.Visible = true;
        }

        public void Hide()
        {
            clock.Visible = false;
        }
    }
}
