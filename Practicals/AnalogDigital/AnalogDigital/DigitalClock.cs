using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigital
{
    public class DigitalClock : IClock
    {
        //Attributes specific to a digital clock
        Label timeDisplay;
        Timer timer;

        //Ctor
        public DigitalClock(Label timeDisplay, Timer timer){
            this.timeDisplay = timeDisplay;
            this.timer = timer;
        }

        public void On()
        {
            timeDisplay.Visible = true;
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
