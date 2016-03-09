﻿using System;
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
            timer.Enabled = true;
        }

        public void Off()
        {
            timer.Enabled = false;
        }

        public void Update()
        {
            timeDisplay.Text = DateTime.Now.ToShortTimeString();
        }

        public void Show()
        {
            timeDisplay.Visible = true;
        }

        public void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
