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

        //Getsets
        public string[] Stack1
        {
            get { return stack; }
            set { stack = value; }
        }
        public int Iterator
        {
            get { return iterator; }
            set { iterator = value; }
        }

        //ctor
        public Stack(int stackSize)
        {
            stack = new string[stackSize];
            iterator = 0;
        }

        //function to add an item to the top of a stack.
        public void Push(string newString)
        {
            try
            {
                //Put argument string into the stack & increment the iterator
                stack[iterator] = newString;
                iterator++;
            }
            catch (IndexOutOfRangeException)
            {
                //Throws an exception if the stack is already full and provides feedback.
                System.IndexOutOfRangeException exString = new System.IndexOutOfRangeException("You attempted to push to a full stack.");
                throw exString;
            }
        }

        //Pops off the most recently item added to the stack.
        public String Pop()
        {
            try { 
                //create a string, used to show user output.
                string mostRecentItem = stack[iterator - 1];

                //Clear the currently watched part of the stack and reduce the iterator.
                stack[--iterator] = null;
                return mostRecentItem;
            }
            catch (IndexOutOfRangeException)
            {
                System.IndexOutOfRangeException exString = new System.IndexOutOfRangeException("You attempted to pop from an empty stack.");
                throw exString;
            }
        }

        //Returns the most recently added item in the stack, but doesn't remove it.
        public String Peek()
        {
            try
            {
                //create a string, used to show user output.
                string mostRecentItem = stack[iterator - 1];
                return mostRecentItem;
            }
            catch (IndexOutOfRangeException)
            {
                System.IndexOutOfRangeException exString = new System.IndexOutOfRangeException("You have attempted to peek an empty stack.");
                throw exString;
            }
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
