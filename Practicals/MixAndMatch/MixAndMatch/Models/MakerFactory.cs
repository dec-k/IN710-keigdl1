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
            }

            return mm;
        }
    }
}
