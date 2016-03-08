using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Sorceror : Character
    {
        //Type-specific attributes

        //Ctor inheriting from base
        public Sorceror(string name)
            : base(name)
        {
            //Bandits start with a spear
            weapon = new mace();
        }

        public override string outputType()
        {
            return "I am a wise Sorceror!";
        }
    }
}
