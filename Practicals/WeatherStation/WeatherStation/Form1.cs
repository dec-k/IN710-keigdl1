using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStation.Observer_Related;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        //Declare instances of the subject + its observers
        //Am i abbreviating these names too much?
        WeatherSubject ws;
        TemperatureObserver tObs;
        AverageObserver aObs;
        ForeCastObserver fObs;

        public Form1()
        {
            InitializeComponent();

            //Instantiate sub+obs
            ws = new WeatherSubject();
            tObs = new TemperatureObserver(lbTemp, ws);
            aObs = new AverageObserver(lbAverages, ws);
            fObs = new ForeCastObserver(lbForecast, ws);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Grab values from textboxes
            //I think this is what could be considered "excessively coupled", ill come back to it.
            try
            {
                int t = Int32.Parse(txtTemp.Text);
                int h = Int32.Parse(txtHumidity.Text);
                int p = Int32.Parse(txtBaro.Text);

                ws.CTemp = t;
                ws.CHumid = h;
                ws.CPressure = p;
                ws.NotifyObservers();
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more fields have invalid data and cannot be processed.");
            }
        }
    }
}
