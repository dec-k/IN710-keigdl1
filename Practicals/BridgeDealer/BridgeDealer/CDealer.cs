using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public class CDealer
    {
        private const int playerCount = 4;
        private CDeck cards;
        private CHand[] players;

        public CDealer()
        {
            cards = new CDeck();
            players = new CHand[playerCount]; //initialize the players array.

            for (int i = 0; i < playerCount; i++) //create a new CHand object for all the players in the players array.
                players[i] = new CHand();
        }

        public void Deal(ListBox lb)
        {
            cards.ShuffledHands(players); //shuffles all the players cards.

            lb.Items.Clear();

            //Revised Code starts here.
            for (int i = 0; i < players.Length; i++)
            {
                lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
                lb.Items.Add("");

                string spades = "S:\t";
                string hearts = "H:\t";
                string diamonds = "D:\t";
                string clubs = "C:\t";

                for (int j = 0; j < players[i].Hand.Length; j++)
                {
                    switch (players[i].Hand[j].Suit)
                    {
                        case SuitValue.SPADES:
                            spades = deteremineDisplayVal(spades, (int)players[i].Hand[j].Number);
                            break;
                        case SuitValue.HEARTS:
                            hearts = deteremineDisplayVal(hearts, (int)players[i].Hand[j].Number);
                            break;
                        case SuitValue.DIAMONDS:
                            diamonds = deteremineDisplayVal(diamonds, (int)players[i].Hand[j].Number);
                            break;
                        case SuitValue.CLUBS:
                            clubs = deteremineDisplayVal(clubs, (int)players[i].Hand[j].Number);
                            break;
                    }
                }

                lb.Items.Add(spades);
                lb.Items.Add(hearts);
                lb.Items.Add(diamonds);
                lb.Items.Add(clubs);
                lb.Items.Add("");

                
            }
        }

        //This method determines what character will be added to the string
        //It has different if statements for values that return non-numeric characters.
        string deteremineDisplayVal(string suitString, int faceVal)
        {
            if (faceVal == 10)
            {
                suitString += "T" + " ";
            }
            else if (faceVal == 11)
            {
                suitString += "J" + " ";
            }
            else if (faceVal == 12)
            {
                suitString += "Q" + " ";
            }
            else if (faceVal == 13)
            {
                suitString += "K" + " ";
            }
            else
            {
                suitString += faceVal + " ";
            }

            return suitString;
        }

    }
}

/*LEGACY CODE        
    for (int i = 0; i < players.Length; i++)
    {
        lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
        lb.Items.Add("");

        for (int j = 0; j < players[i].Hand.Length; j++)
            lb.Items.Add(players[i].Hand[j].ToString()); //adds each of the players cards to the list box.

        lb.Items.Add("");
        lb.Items.Add("HCP: " + players[i].TotalPoints().ToString()); //outputs the players high card point score.
        lb.Items.Add("-----------");
    }
 */
