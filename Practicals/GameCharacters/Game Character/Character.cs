using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        //Attributes shared between children
        protected string characterName;
        protected IWeapon weapon;

        //Ctor
        public Character(string characterName)
        {
            this.characterName = characterName;
        }

        //Methods
        
        //Returns the fluff statement of the characters name.
        //All children implement this method the same way.
        public string outputName(){
            return "My name is " + characterName + "!";
        }

        //Method stub which means children must have an implementation of this method.
        public virtual string outputType();
    }
}
