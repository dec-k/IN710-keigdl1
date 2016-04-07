using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikesSubObs
{
    class RPMObserver : BicycleObserver
    {
        //ctor
        public RPMObserver(Label displayLabel, Subject bikeSubject)
            :base(displayLabel,bikeSubject)
        {

        }

        //methods
        public override void Update(int currentRPM)
        {
            currentComputedValue = currentRPM;
        }
    }
}
