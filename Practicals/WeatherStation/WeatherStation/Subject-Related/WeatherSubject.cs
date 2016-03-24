using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherSubject : ISubject
    {
        //Subject base attrbutes, similar to base observer actually
        protected List<IWeatherObserver> obsList;
        protected int cTemp;
        protected int cHumid;
        protected int cPressure; 

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
