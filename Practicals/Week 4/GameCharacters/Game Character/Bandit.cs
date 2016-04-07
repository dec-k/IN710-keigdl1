using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Bandit : Character
    {
        //Type-specific attributes

        //Ctor inheriting from base
        public Bandit(string name)
            : base(name)
        {
            //Bandits start with a spear
            weapon = new spear();
        }

        public override string outputType()
        {
            return "I am a deceitful Bandit!";
        }
    }
}
