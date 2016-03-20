﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.MixableClasses
{
    interface ICharMaker
    {
        Head createHead();
        Body createBody();
        Legs createLegs();
    }
}
