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
        
        public void Peek_OnEmptyStack_ReturnsExceptionHandler()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);
            target.Peek();

            bool expected = true;
            bool actual = target.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
    }
}
