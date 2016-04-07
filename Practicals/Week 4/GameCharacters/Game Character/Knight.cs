using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Knight : Character
    {
        //Type-specific attributes

        //Ctor inheriting from base
        public Knight(string name)
            : base(name)
        {
            weapon = new sword();
        }

        public override string outputType()
        {
            return "I am a honorable Knight.";
        }
    }
}
