using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTests
{
    public class Stack
    {
        //Array of strings for the stack
        //Note to self: If you get extra time, rewrite this as a linked list. Arrays are overly simple. :(
        string[] stack;

        //Iterator keeps count of the stacks size
        int iterator;

        //ctor
        public Stack(int stackSize)
        {
            stack = new string[stackSize];
            iterator = 0;
        }

        //function to add an item to the top of a stack.
        public void Push(string newString)
        {

                //Case to check if stack is full before adding an item to the array.
                if (iterator < stack.Length)
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
            try
            {
                //create a string, used to show user output.
                string mostRecentItem = stack[iterator];

                //Clear the currently watched part of the stack.
                stack[iterator] = null;
                return "'" + mostRecentItem + "' has been removed from the stack.";
            }
            catch (IndexOutOfRangeException)
            {
                //Reset the iterator value to prevent a crash.
                iterator = +1;
                return "You attempted to pop when the stack was empty.";
            }
        }

        //Returns the most recently added item in the stack, but doesn't remove it.
        public String Peek()
        {
            //create a string, used to show user output.
            string mostRecentItem = stack[iterator];

            return "'" + mostRecentItem + "' was the last item added to the stack.";
        }

        //Returns the count of items in the stack.
        public int Count()
        {
            return iterator;
        }

        //Checks if the stack is empty
        public bool IsEmpty()
        {
            //Checks if the iterator is zero, and if the content at zero is blank.
            //== null is used when the stack is fresh and hasnt had anything put in it yet,
            //== "" is used when something was there, but has been removed from the stack.
            if (iterator == 0 && (stack[iterator] == null || stack[iterator] == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
