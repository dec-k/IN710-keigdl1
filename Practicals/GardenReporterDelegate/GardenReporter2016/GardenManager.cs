using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    class GardenManager
    {
        //List of gardens, form provides this.
        List<Garden> gardenList;

        //Ctor
        public GardenManager()
        {
            //Instantiate gardenList
            gardenList = new List<Garden>();
        }

        //Method to add the passed-in garden to the garden list.
        public void AddGarden(Garden g)
        {
            gardenList.Add(g);
        }
    }
}
