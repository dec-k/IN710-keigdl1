using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    interface ISubject
    {
        //Declare standard subject patterns
        void AddObserver(IWeatherObserver o);
        void RemoveObserver(IWeatherObserver o);
        void NotifyObservers();
    }
}
