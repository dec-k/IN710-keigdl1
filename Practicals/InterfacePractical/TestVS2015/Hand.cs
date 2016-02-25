using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand : IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);

            //Runs a sort method here
            //Just a comment stub so I remember where I made a change.
            CardsInHand.Sort();
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public int CompareTo(Hand other)
        {
            if (other is Hand)
            {
                return other.TotalHCP.CompareTo(this.TotalHCP);
            }
            throw new ArgumentException("Object is not of type Hand.");
        }
    }
}