using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTDDKata1;

namespace StringCalculatorTDDKata1_Tests
{
    [TestClass]
    public class AddTests
    {
        private StringCalculator _stringCalculator;

        [TestInitialize]
        public void Setup()
        {
            _stringCalculator = new StringCalculator();
        }

        [TestMethod]
        public void Add_With_Empty_String_Returns_0()
        {
            var result = _stringCalculator.Add("");
            Assert.AreEqual(result, 0);
        }

        
    }
}
