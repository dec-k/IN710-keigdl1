﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class AustralianAnimalFactory : IAnimalFactory
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
                    newAnimal = new Koala();
                    break;
                case 1:
                    newAnimal = new Kangaroo();
                    break;
                case 2:
                    newAnimal = new Crocodile();
                    break;
                case 3:
                    newAnimal = new Wombat();
                    break;
            }

            //Return
            return newAnimal;
        }
    }
}
