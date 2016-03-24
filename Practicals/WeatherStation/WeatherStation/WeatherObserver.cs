using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    class WeatherObserver : IWeatherObserver
    {
        //Attributes of base class
        protected int cTemp;
        protected int cHumid;
        protected int cPressure;

        //Listbox instance that will have content passed to it
        protected ListBox lb;

        //Ctor
        public WeatherObserver(ListBox lb, WeatherSubject ws)

        //Instance of a subject
        public void Update(int temp, int humidity, int pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
