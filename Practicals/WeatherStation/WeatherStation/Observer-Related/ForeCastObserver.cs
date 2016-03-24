using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation.Observer_Related
{
    class ForeCastObserver : WeatherObserver
    {
        //attributes of a good weather forecast
        //Stored as strings, no numbers allowed!
        string temp;
        string baro;
        string humid;

        //blank ctor
        public ForeCastObserver(ListBox lb, WeatherSubject ws)
            : base(lb,ws)
        {

        }

        public override void Update(int cTemp, int cHumid, int cPressure)
        {
            //Determine how spicy the weather is
            if (cTemp > 0 && cTemp < 10)
            {
                temp = "Nippy";
            }
            else if (cTemp > 10 && cTemp < 20)
            {
                temp = "Cool";
            }
            else if (cTemp > 20 && cTemp < 30)
            {
                temp = "Medium Spicy";
            }
            else if (cTemp > 30)
            {
                temp = "Way too spicy!!";
            }

            //Same deal for humidity
            //Determine how spicy the weather is
            if (cHumid > 0 && cHumid < 25)
            {
                humid = "Dry as a bone";
            }
            else if (cHumid > 25 && cHumid < 50)
            {
                humid = "Slightly Moist";
            }
            else if (cHumid > 50 && cHumid < 75)
            {
                humid = "Auckland-tier";
            }
            else if (cHumid > 75)
            {
                humid = "Asian Tropics Tier";
            }
            else if (cHumid > 100 || cHumid < 0)
            {
                humid = "invalid value";
            }

            //Barometric pressure
            if (cPressure > 0 && cPressure < 50)
            {
                baro = "Normal barometric pressure";
            }
            else
            {
                baro = "Very atypical baro pressure, don't leave the house";
            }
        }

        //Custom display method
        public override void Display()
        {
            //clear lb
            lb.Items.Clear();
            lb.Items.Add("Temperature today will be " + temp);
            lb.Items.Add("Expect the humidity to be " + humid);
            lb.Items.Add("We will be experiencing " + baro + " today.");
        }
    }
}
