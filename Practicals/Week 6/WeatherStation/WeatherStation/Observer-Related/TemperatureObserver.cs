using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation.Observer_Related
{
    public class TemperatureObserver : WeatherObserver
    {
        //Temp obs doesnt need any attrbutes other than base
        public TemperatureObserver(ListBox lb, WeatherSubject ws)
            : base(lb, ws)
        {
            //Blank ctor
        }

        public override void Update(int cTemp, int cHumid, int cPressure)
        {
            //Convert passed in values to their double counterparts
            CCompTemp = cTemp;
            CCompHumid = cHumid;
            CCompPressure = cPressure;
        }
    }
}
