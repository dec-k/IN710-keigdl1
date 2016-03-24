using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class ISubject
    {
        //Standard subject method declarations
        void AddObserver(IWeatherObserver o);
        void RemoveObserver(IWeatherObserver o);
        void NotifyObservers();
    }
}
