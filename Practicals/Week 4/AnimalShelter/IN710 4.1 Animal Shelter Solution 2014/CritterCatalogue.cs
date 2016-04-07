using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{

    public class CritterCatalogue
    {
        string inputFileName;
        private List<Critter> critterList;

        //=======================================================================
        // Ctor
        //=======================================================================
        public CritterCatalogue(string inputFileName)
        {
            this.inputFileName = inputFileName;
            critterList = new List<Critter>();
            loadCritterList();
        }

        //=======================================================================
        // Returns a List<Critter> containing all Critters in class member 
        // critterList whose species is equal to the passed in argument.
        // NB: Critter.species is an enum; the passed in argument is a string.
        // Explore System.Enum.Parse for solution.
        //=======================================================================
        public List<Critter> CritterQuery(string speciesName)
        {
            //Declare a list only used for this method,
            //Holds a list of animals of the arg's species.
            List<Critter> critSpecies = new List<Critter>();

            //Instantiate an enum and then parse it so it can be used properly further down.
            //(Credit to Leonard for helping me work this out, I had a lot of trouble on my own.)
            ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), speciesName);
 
            //Loop through critterList
            foreach (Critter c in critterList)
            {
                //When arg's specie-type matches a critter, add it to the passed-out list.
                if (c.Species == currentSpecies)
                {
                    critSpecies.Add(c);
                }
            }
            
            //Return
            return critSpecies;
        }


        //=======================================================================
        // Reads in and parses the text file.
        // Creates a Critter instance for each entry, and loads them into the
        // class member List<Critter> critterList
        //=======================================================================
        private void loadCritterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;


                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);
                    critterList.Add(new Critter(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

        //=======================================================================
        // Prints critterList to the paseed-in ListBox
        //=======================================================================
        public void PrintAllCritters(ListBox displayBox)
        {
            displayBox.Items.Clear();
            foreach (Critter c in critterList)
            {
                displayBox.Items.Add(c.ToString());
            }
        }

       

    }
}
