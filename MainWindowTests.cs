using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace calculator.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void CheckToFloatFunctionTest()
        {
            Assert.AreEqual(2.5, MainWindow.ToFloat("2,5"));
        }

        [TestMethod()]
        public void ValidateString()
        {
            MainWindow.ValidateString validator = new MainWindow.ValidateString();

            bool existInString = validator.Validate("test123", '1');

            Assert.AreEqual(true, existInString);
        }
    }
}