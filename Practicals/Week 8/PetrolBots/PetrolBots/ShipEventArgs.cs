﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class ShipEventArgs : EventArgs
    {
        //var to hold ship loc
        Point shipLocation { get; set; }
        EShipState state;

        //ctor
        public ShipEventArgs(EShipState state)
        {
            this.state = state;
        }
    }
}
