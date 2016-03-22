using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikesSubObs
{
    class CalObserver : BicycleObserver
    {
        //ctor
        public CalObserver(Label displayLabel, Subject bikeSubject)
            :base(displayLabel,bikeSubject)
        {

        }
        
        //method
        public override void Update(int currentRPM)
        {
            currentComputedValue = currentRPM * 5;
        }
    }
}
