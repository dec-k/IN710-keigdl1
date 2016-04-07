using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikesSubObs
{
    class KMObserver : BicycleObserver
    {
        //ctor
        public KMObserver(Label displayLabel, Subject bikeSubject)
            :base(displayLabel,bikeSubject)
        {

        }

        //methods
        public override void Update(int currentRPM)
        {
            currentComputedValue = ((double)currentRPM * 60 * 205) / 10000;
        }
    }
}
