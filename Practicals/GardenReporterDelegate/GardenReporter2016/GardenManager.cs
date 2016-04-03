using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    class GardenManager
    {
        //List of gardens, form provides this.
        List<Garden> gardenList;
        string returnString;

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

        //Method to iterate over the garden list, outputting name & area.
        public void IterateGetArea(ListBox lb)
        {
            //Clear lb before processing
            lb.Items.Clear();

            //iterate over list and run the garden's GetArea() method
            for (int i = 0; i < gardenList.Count; i++)
            {
                //Format the output string as specified in the handout
                 returnString = String.Format("{0,-14}:{1,8:f2}",gardenList[i].OwnerName, gardenList[i].GetArea());
                 lb.Items.Add(returnString);
            }
        }

        //Method to iterate over the garden list, outputting name & charges.
        public void IterateGetBalance(ListBox lb)
        {
            //Clear lb before processing
            lb.Items.Clear();

            //iterate over list and run the garden's GetAccountBalance() method
            for (int i = 0; i < gardenList.Count; i++)
            {
                //Format the output string as specified in the handout
                returnString = String.Format("{0,-14}:{1,8:C2}", gardenList[i].OwnerName, gardenList[i].GetAccountBalance());
                lb.Items.Add(returnString);
            }
        }
    }
}
