using MixAndMatch.MixableClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.Models
{
    class MakerFactory : ICharacterMaker
    {
        public ModelMaker createModelMaker(string selected)
        {
            //Model skeleton
            ModelMaker mm = null;

            //Determine which creature to make
            switch (selected)
            {
                case "Fairy":
                    mm = new Fairy();
                    break;
                case "Frankenstein":
                    mm = new Fairy();
                    break;
                case "Werewolf":
                    mm = new Fairy();
                    break;
                case "Vampire":
                    mm = new Fairy();
                    break;
                case "Witch":
                    mm = new Fairy();
                    break;
                case "Skeleton":
                    mm = new Fairy();
                    break;
            }

            return mm;
        }
    }
}
