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

    }
}
