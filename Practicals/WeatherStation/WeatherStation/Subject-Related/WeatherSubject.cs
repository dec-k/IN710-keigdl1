using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherSubject : ISubject
    {
        //Subject base attrbutes, similar to base observer actually
        private List<IWeatherObserver> obsList;
        private int cTemp;
        private int cHumid;
        private int cPressure;

        //Getsets
        public List<IWeatherObserver> ObsList
        {
            get { return obsList; }
            set { obsList = value; }
        }
        public int CTemp
        {
            get { return cTemp; }
            set { cTemp = value; }
        }
        public int CHumid
        {
            get { return cHumid; }
            set { cHumid = value; }
        }
        public int CPressure
        {
            get { return cPressure; }
            set { cPressure = value; }
        } 

        //Ctor
        public WeatherSubject()
        {
            //instantiate attributes
            obsList = new List<IWeatherObserver>();
            cTemp = 0;
            cHumid = 0;
            cPressure = 0;
        }

        //Methods
        public void AddObserver(IWeatherObserver o)
        {
            //Add the passed in observer to the observer list
            obsList.Add(o);
        }

        public void RemoveObserver(IWeatherObserver o)
        {
            //Remove specifed from list
            obsList.Remove(o);
        }

        public void NotifyObservers()
        {
            //Alert all observers that they will need to update their information
            foreach (WeatherObserver obs in obsList)
            {
                obs.Update(cTemp, cHumid, cPressure);
                obs.Display();
            }
        }
    }
}
