using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IWeatherObserver
    {
        //Declare standard observer methods: update and display.
        void Update(int temp, int humidity, int pressure);
        void Display();
    }
}
