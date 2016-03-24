using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace WeatherUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_EmptyTextField_ReturnsTrue()
        {
            TextBox txtTest1 = null;
            TextBox txtTest2 = null;
            TextBox txtTest3 = null;

            string expected = "One or more fields have invalid data and cannot be processed.";
            string actual = txtTest.Text;

        }
    }
}
