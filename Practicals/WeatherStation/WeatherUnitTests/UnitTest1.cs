using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using WeatherStation;
using WeatherStation.Observer_Related;
using System.Collections.Generic;

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
            AverageObserver aObs = new AverageObserver(lb, ws);

            //Update tobs with some values
            aObs.Update(23,1,1);

            double expected = 23.00;
            double actual = aObs.CCompTemp;

            Assert.AreEqual(expected, actual);
        }

        //Ensure temp observer can return correct value
        [TestMethod]
        public void TempObs_UpdateValues_ReturnsExpected()
        {
            //Create needed objects
            ListBox lb = new ListBox();
            WeatherSubject ws = new WeatherSubject();
            TemperatureObserver tObs = new TemperatureObserver(lb, ws);

            //Update tobs with some values
            tObs.Update(23, 1, 1);

            double expected = 23.00;
            double actual = tObs.CCompTemp;

            Assert.AreEqual(expected, actual);
        }

        //Ensure forecast observer can return correct value
        [TestMethod]
        public void ForecastObs_UpdateValues_ReturnsExpected()
        {
            //Create needed objects
            ListBox lb = new ListBox();
            WeatherSubject ws = new WeatherSubject();
            ForeCastObserver fcObs = new ForeCastObserver(lb,ws);

            //Update tobs with some values
            fcObs.Update(1, 1, 1);

            //Just test on temperature, for full code coverage id need:
            //~3 tests to cover each branch of temperature-related strings
            //*3 for the amount of forecast options (temp,humid,baro)
            string expected = "Nippy";
            string actual = fcObs.Temp;

            Assert.AreEqual(expected, actual);
        }

        //Ensure an observer can be added to the subject
        [TestMethod]
        public void ObserverList_AddObserver_ReturnsExpected()
        {
            //Create needed objects
            ListBox lb = new ListBox();
            WeatherSubject ws = new WeatherSubject();
            List<IWeatherObserver> obList = new List<IWeatherObserver>();

            //Make 2 observers, do not manually add these
            //Their ctor adds them to the passed subject
            ForeCastObserver fcObs1 = new ForeCastObserver(lb, ws);
            ForeCastObserver fcObs2 = new ForeCastObserver(lb, ws);
            
            //Expected size of list
            int expected = 2;
            int actual = ws.ObsList.Count;

            //Check observer was added to observer list properly
            Assert.AreEqual(expected, actual);
        }
    }
}
