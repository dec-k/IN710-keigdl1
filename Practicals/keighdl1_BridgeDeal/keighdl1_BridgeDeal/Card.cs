using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keighdl1_BridgeDeal
{
    class Card
    {
        //Attributes
        int suit;
        int faceVal;
        int hcpVal;
        char displayVal;

        public Card(char suit, int faceVal, int hcpVal, char displayVal)
        {
            this.suit = suit;
            this.faceVal = faceVal;
            this.hcpVal = hcpVal;
            this.displayVal = displayVal;
        }

        //Get and set
        public char DisplayVal
        {
            get { return displayVal; }
            set { displayVal = value; }
        }
        public int HcpVal
        {
            get { return hcpVal; }
            set { hcpVal = value; }
        }
        public int FaceVal
        {
            get { return faceVal; }
            set { faceVal = value; }
        }
        public char Suit
        {
            get { return suit; }
            set { suit = value; }
        }
        
    }
}
