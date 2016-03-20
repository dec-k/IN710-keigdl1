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
                    mm = new Frankenstein();
                    break;
                case "Werewolf":
                    mm = new Werewolf();
                    break;
                case "Vampire":
                    mm = new Vampire();
                    break;
                case "Witch":
                    mm = new Witch();
                    break;
                case "Skeleton":
                    mm = new Skeleton();
                    break;
            }

            return mm;
        }
    }
}
