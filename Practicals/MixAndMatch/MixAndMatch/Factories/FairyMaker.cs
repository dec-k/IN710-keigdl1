using MixAndMatch.MixableClasses;
using MixAndMatch.MixableClasses.ChildClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.Factories
{
    class FairyMaker : ICharMaker
    {
        //Create blank slate creature
        Head h = null;
        Body b = null;
        Legs l = null;

        //Methods to return parts individually
        public Head createHead()
        {
            h = new FairyHead();
            return h;
        }

        public Body createBody()
        {
            b = new FairyBody();
            return b;
        }

        public Legs createLegs()
        {
            l = new FairyLegs();
            return l;
        }
    }
}
