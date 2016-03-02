﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        //Head and tail pointers for the collection
        Pellet headPointer = null;
        Pellet tailPointer = null;

        //Required vars to setup a list of pellets.
        const int MAX_PELLETS_DISPLAY = 1000;
        int pelletCount;
        Pellet[] pelletList;

        Rectangle boundsRectangle;

        //==============================================================================
        // Constructor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            //Important! Set head & tail to null at init otherwise things go boom. Big boom.
            headPointer = null;
            tailPointer = null;

            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            //First, check if we are attempting to add to an empty list
            if (headPointer == null)
            {
                //Then we assign the new pellet as both head & tail - now we have a list
                //which is 1 pellet long.
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else 
            {
                //If the list isn't empty, append the new pellet to the end of the list
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            //Setup a count and a nodewalker which is used to step-through the linked list.
            int count = 0;
            Pellet listWalker = headPointer; //This is a reference to the pellet currently assigned as head. I think.
            
            //Step through the list, and so long as listWalker doesn't become null the count will increment.
            while(listWalker != null){
                count++;
                listWalker = listWalker.Next;
                //Explanation of listWalker.next:
                //Fetches the referred-to value of listWalker, and gets its "next" value, if it
                //returns nullptr at any point, this means the end of the list has been reached.
            }
            
            //Return count - which will be the total size of the list.
            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            int count = 0;
            Pellet listWalker = headPointer;

            while (listWalker != null)
            {
                //Call the listWalker's reference's move() method to animate it across the form.
                listWalker.Move();
                count++;
                listWalker = listWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            int count = 0;
            Pellet listWalker = headPointer;

            while (listWalker != null)
            {
                //Call the listWalker's reference's TestOutOfBounds() method determine
                //if the pellet is still present on the form.
                if (listWalker.TestOutOfBounds(boundsRectangle) == true)
                {
                    //Flag that pellet's isAlive property as false.
                    listWalker.IsAlive = false;
                }
                //Continue checking the rest of the list.
                count++;
                listWalker = listWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
