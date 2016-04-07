using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    class Continent
    {
        //Constant for amount of available animals
        //Does this break down if different continents have different numbers of available animals?
        public const int ANIMAL_SIM_COUNT = 4;

        //Note: These fields introduce some UI coupling which could be reduced by creating an
        //intermediary class to hold exclusively UI-related fields.
        protected ListBox displayBox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        //Ctor
        public Continent(ListBox displayBox, Random rGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        //Method to execute the simulation.
        public void runSim()
        {
            //Empty animal
            Animal currentAnimal;

            //
            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                //Select an animal type
                int animalChoice = rGen.Next(nAnimalTypes);

                //Feed the random number above into a factory's createAnimal method,
                //which is then put through a switch to determine the animal type.
                currentAnimal = animalFactory.createAnimal(animalChoice);

                //[Coupled] Add the animal to the form.
                //Output their toString
                displayBox.Items.Add(currentAnimal.ToString());

                //Create a rectangle so pictures get resized to fit on screen.
                Rectangle container = new Rectangle(20, 20+(i*105),200,100);
                Rectangle src = new Rectangle(20, 20, 600, 300);

                //How I think this works (Might be wrong):
                //Container is the bounds of the canvas.
                //src is the amount of pixels (width & width) that are put into the container? So in my code it's squeezing 600px of the image into 100px of the container.

                //Define the unit of measurement for the above values, pixels.
                GraphicsUnit units = GraphicsUnit.Pixel;

                //Draw their jpg to a form box
                //canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120));
                canvas.DrawImage(currentAnimal.Image, container, src, units);
            }
        }
    }
}
