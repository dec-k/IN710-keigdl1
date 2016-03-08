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
        public string characterName;
        public IWeapon weapon;

        //GetSet for name
        protected string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

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

        //Returns the characters "weapon usage" string.
        public string useCharactersWeapon()
        {
            return weapon.useWeapon();
        }

        //Method stub which means children must have an implementation of this method.
        public  abstract string outputType();
    }
}
