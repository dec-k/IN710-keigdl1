using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WeatherStation;
using WeatherStation.Observer_Related;

namespace WeatherUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //Ensure average observer can return correct value
        [TestMethod]
        public void AvgObs_UpdateValues_ReturnsExpected()
        {
            //Create needed objects
            ListBox lb = new ListBox();
            WeatherSubject ws = new WeatherSubject();
            TemperatureObserver tObs = new TemperatureObserver(lb, ws);

            //Update tobs with some values
            tObs.Update(23,1,1);

            double expected = 23.00;
            double actual = tObs.

        }
    }
}
