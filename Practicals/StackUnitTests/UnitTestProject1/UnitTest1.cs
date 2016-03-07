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

            string expected = "C";
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

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(IndexOutOfRangeException),"You have attempted to Pop an empty stack.")]
        public void Pop_OnEmptyStack_ReturnsExceptionHandler()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Attempt to pop an empty stack - will return outofrange exception with a message.
            target.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "You have attempted to Push to a stack with no available space.")]
        public void Push_OnFullArray_ReturnsExceptionHandler()
        {
            //Set stack size low for easy testing.
            int stackTestSize = 2;
            Stack target = new Stack(stackTestSize);

            //Push stub data
            target.Push("a");
            target.Push("a");
            
            //This push will overflow the array and throw an exception.
            target.Push("a");
        }

        [TestMethod]
        public void Peek_OnFullStackArray_ReturnCorrectItem()
        {
            //Assemble
            int stackTestSize = 2;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("a");
            target.Push("B");

            string expected = target.Peek();
            string actual = "B";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_OnFilledThenEmptiedStack_ReturnCorrectItem()
        {
            //Assemble
            int stackTestSize = 3;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");
            target.Push("B");
            target.Push("C");

            //Pop all but one item from the stack.
            target.Pop();
            target.Pop();

            string expected = target.Peek();
            string actual = "A";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_OnFilledThenEmptiedStack_ReturnsOne()
        {
            //Assemble
            int stackTestSize = 3;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");
            target.Push("B");

            //Pop all but one item from the stack.
            target.Pop();

            //Verify that count has returned value of 1.
            int expected = 1;
            int actual = target.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Is this test redundant because of the one above?
        [TestMethod]
        public void Count_OnFilledMinusOneStack_ReturnsFour()
        {
            //Assemble
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");
            target.Push("B");
            target.Push("C");
            target.Push("D");
            target.Push("E");

            //Pop the last item from the stack.
            target.Pop();

            //Verify that count has returned value of 4.
            int expected = 4;
            int actual = target.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_OnStackWithItems_ReturnsFalse()
        {
            //Assemble
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");

            bool expected = false;
            bool actual = target.IsEmpty();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_OnStackWithOneItem_ReturnsCorrectFeedback()
        {
            //Assemble
            int stackTestSize = 1;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");

            //Verify that pop has given the correct user-friendly feedback.
            string expected = "A";
            string actual = target.Pop();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_OnStackThatUsedToHaveItems_Returns()
        {
            //Assemble
            int stackTestSize = 3;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");
            target.Push("B");
            target.Push("C");
            target.Pop();
            target.Pop();

            //Verify that an array can be filled and then all elements can be popped from it.
            string expected = "A";
            string actual = target.Pop();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_OnFullStack_ReturnsFalse()
        {
            //Assemble
            int stackTestSize = 3;
            Stack target = new Stack(stackTestSize);

            //Act
            target.Push("A");
            target.Push("B");
            target.Push("C");

            bool expected = false;
            bool actual = target.IsEmpty();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
