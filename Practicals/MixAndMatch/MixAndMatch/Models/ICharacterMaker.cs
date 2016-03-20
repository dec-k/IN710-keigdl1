using MixAndMatch.MixableClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch.Models
{
    interface ICharacterMaker
    {
        ModelMaker createModelMaker(string selected);
    }
}
