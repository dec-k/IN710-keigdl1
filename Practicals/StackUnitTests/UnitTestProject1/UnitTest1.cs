using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUnitTests;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_EmptyStackNull_ReturnsTrue()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            bool expected = true;
            bool actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_EmptyStackBlankString_ReturnsTrue()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Add item to stack
            target.Push("TestItem");
            //Pop from stack
            target.Pop();

            bool expected = true;
            bool actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException),"You have attempted to Peek an empty stack.")]
        public void Peek_OnEmptyStack_ReturnsExceptionHandler()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Peek on an empty stack - will throw an exception in the test.
            target.Peek();
        }

        [TestMethod]

        public void Peek_OnStackWithItems_ReturnsLastAdded()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Push stub data to stack
            target.Push("A");
            target.Push("B");
            target.Push("C");

            string expected = "C was the most recent item added to stack.";
            string actual = target.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_OnEmptyStack_ReturnsZero()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            int expected = 0;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        
        public void Count_OnStackWithItems_ReturnsTwo()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Push stub data
            target.Push("a");
            target.Push("a");

            int expected = 2;
            int actual = target.Count();

            Assert.AreEqual(expected, actual);
        }
    }
}
