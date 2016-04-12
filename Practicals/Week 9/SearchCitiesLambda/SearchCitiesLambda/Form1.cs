using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchCitiesLambda
{
    public partial class Form1 : Form
    {
        //List of cities
        List<City> cityList;

        public Form1()
        {
            InitializeComponent();

            cityList = new List<City>();

            //create some cities
            City c1 = new City("Dunedin", "New Zealand", 10000);
            City c2 = new City("Wellington", "New Zealand", 25000);
            City c3 = new City("Christchurch", "New Zealand", 53);
            City c4 = new City("Wanaka", "New Zealand", 7500);
            City c5 = new City("Auckland", "New Zealand", 900000);

            //add to list
            cityList.Add(c1);
            cityList.Add(c2);
            cityList.Add(c3);
            cityList.Add(c4);
            cityList.Add(c5);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get val out of search box
            string searchString = txtSearch.Text;

            //func using lambda
            Func<string, string, bool> searchCities = (c1, c2) => c1.Equals(c2);

            foreach(City c in cityList){
                //check if search matches
                if (searchCities(searchString, c.CountryName))
                {
                    //add to list
                    lbResults.Items.Add(c.ToString());
                }
            }

        }
    }
}
