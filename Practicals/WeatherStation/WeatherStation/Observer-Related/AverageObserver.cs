using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation.Observer_Related
{
    public class AverageObserver : WeatherObserver
    {
        //Full disclosure, I struggled a bit with the code for averaging.
        //I had help from Joe's code @ github.com/sleemjm1

        //Attributes needed to calculate averages
        int runningTemp;
        int runningHumid;
        int runningPressure;
        int simCount; //Total times calculations have been run

        //Ctor
        public AverageObserver(ListBox lb, WeatherSubject ws)
            : base(lb,ws)
        {
            //Init vals
            runningTemp = 0;
            runningHumid = 0;
            runningPressure = 0;
            simCount = 0;
        }

        public override void Update(int cTemp, int cHumid, int cPressure)
        {
            runningTemp += cTemp;
            runningHumid += cHumid;
            runningPressure += cPressure;
            //Increment simcoutn
            simCount += 1;

            //calc averages
            cCompTemp = runningTemp / simCount;
            cCompHumid = runningHumid / simCount;
            cCompPressure = runningPressure / simCount;
        }
    }
}
