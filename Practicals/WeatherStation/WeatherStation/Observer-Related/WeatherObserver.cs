using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public abstract class WeatherObserver : IWeatherObserver
    {
        //Attributes of base class
        private int cTemp;
        private int cHumid;
        private int cPressure;

        //Accessors
        protected int CTemp
        {
            get { return cTemp; }
            set { cTemp = value; }
        }
        protected int CHumid
        {
            get { return cHumid; }
            set { cHumid = value; }
        }
        protected int CPressure
        {
            get { return cPressure; }
            set { cPressure = value; }
        }

        //Values for when computations are being run on variables that will require decimal points
        protected double cCompTemp;
        protected double cCompHumid;
        protected double cCompPressure; 


        //Listbox instance that will have content passed to it
        protected ListBox lb;
        protected WeatherSubject ws;

        //Ctor
        public WeatherObserver(ListBox lb, WeatherSubject ws)
        {
            //Inititialise attributes
            cTemp = 0;
            cHumid = 0;
            cPressure = 0;

            //Bind form control to local variable (I still can't explain these lines very well)
            this.lb = lb;
            this.ws = ws;

            //Add this brand-spanking new obs to the obs list
            ws.AddObserver(this);
        }

        //Instance of a subject
        //Like the bike one, update will be overwritten by its descendants.
        public abstract void Update(int cTemp, int cHumid, int cPressure);

        public virtual void Display()
        {
            //Clear before adding more
            lb.Items.Clear();

            //Load 'er up!
            lb.Items.Add("Temperature: " + cCompTemp.ToString("F1")); //F1 formats to 1 dp
            lb.Items.Add("Humidity: " + cCompHumid.ToString("F1")); //F1 formats to 1 dp
            lb.Items.Add("Pressure: " + cCompPressure.ToString("F1")); //F1 formats to 1 dp 
        }
    }
}
