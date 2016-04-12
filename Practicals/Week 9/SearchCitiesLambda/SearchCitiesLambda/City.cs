using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchCitiesLambda
{
    class City
    {
        //attr
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }

        //ctor
        public City(string cityName, string countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }
    }
}
