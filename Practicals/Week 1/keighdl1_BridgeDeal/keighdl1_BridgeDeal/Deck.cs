using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keighdl1_BridgeDeal
{
    class Deck
    {
        //Attributes
        const int valueCount = 13;
        const int suitCount = 4;
        private Card[,] deck;

        public Deck()
        {
            //Populate deck with card instances
            deck = new Card[suitCount, valueCount];
            for (int suits = 0; suits < suitCount; suits++)
            {
                for (int values = 0; values < valueCount; values++)
                {
                    deck[suits, values] = new Card(suits, values, 0, values);
                }
            }
        }
    }
}
