using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    interface IAnimalFactory
    {
        //A factory at it's most basic is essentially just a method - seen here.
        Animal createAnimal(int animalCode);
    }
}
