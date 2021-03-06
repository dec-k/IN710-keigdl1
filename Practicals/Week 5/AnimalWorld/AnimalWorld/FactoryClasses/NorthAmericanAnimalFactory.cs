﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class NorthAmericanAnimalFactory : IAnimalFactory
    {
        //Code for this factories implementation of createAnimal (req'd by the interface)
        public Animal createAnimal(int animalCode)
        {
            //Create an "empty" animal, which will later be loaded with a specific instance of an animal.
            Animal newAnimal = null;

            //Switch to determine which animal type was requested.
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Bison();
                    break;
                case 1:
                    newAnimal = new Eagle();
                    break;
                case 2:
                    newAnimal = new Wolf();
                    break;
                case 3:
                    newAnimal = new Armadillo();
                    break;
            }

            //Return
            return newAnimal;
        }
    }
}
