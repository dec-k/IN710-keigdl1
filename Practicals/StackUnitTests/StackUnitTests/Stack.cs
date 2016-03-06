using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTests
{
    class Stack
    {
        //Array of strings for the stack
        //Note to self: If you get extra time, rewrite this as a linked list. Arrays are overly simple. :(
        string[] stack;

        //Iterator & boundary checker.
        int iterator;
        int boundary; //Again, only really needed because it's an array not a linked list.

        //ctor
        public Stack(int stackSize /*This isn't needed if using a linked list.*/)
        {
            stack = new string[stackSize];
            iterator = 0;
            boundary = stackSize;
        }

        //function to add an item to the top of a stack.
        public void Push(string newString)
        {
            //Case to check if stack is full before adding an item to the array.
            if (iterator == boundary) 
            {
                //Put argument string into the stack & increment the iterator
                stack[iterator] = newString;
                iterator++;
            }
            else
            {
                //Feedback to let user know the stack was full
                //ADD ME
            }
        }

        //Pops off the most recently item added to the stack.
        public String Pop()
        {
            //create a string, used to show user output.
            string mostRecentItem = stack[iterator];

            stack[--iterator] = ""; //Reduce the iterator, gets the most recently assigned slot, and means that the push method will overwrite in the right place later.
            //Note: As I wrote this, I became aware that having an array almost defeats the point of the stack. The memory doesn't de-allocate for the 'blank' array slots..
            return mostRecentItem + " has been removed from the stack.";
        }

        //Returns the most recently added item in the stack, but doesn't remove it.
        public String Peek()
        {
            //create a string, used to show user output.
            string mostRecentItem = stack[iterator];

            return mostRecentItem + " was the last item added to the stack.";
        }

    }
}
