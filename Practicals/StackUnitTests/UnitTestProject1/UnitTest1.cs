using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            //Near-arbitrary stack size for the creation of the stack:
            int stackTestSize = 5;
            Stack target = new Stack(stackTestSize);

            bool expected = true;
            bool actual = stackTestSize.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
    }
}
