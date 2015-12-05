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
        public void Empty_String_Returns_0()
        {
            var result = _stringCalculator.Add("");
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Numberless_String_Returns_0()
        {
            var result = _stringCalculator.Add("This is a String with no numbers");
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void One_Number_String_Returns_Sum()
        {
            var result = _stringCalculator.Add("4");
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Two_Comma_Sepearted_Numbers_Returns_Sum()
        {
            var result = _stringCalculator.Add("2,4");
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void Three_Comma_Seperated_Numbers_Returns_Sum()
        {
            var result = _stringCalculator.Add("2,4,6");
            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void Space_Seperated_Numbers_Return_0()
        {
            var result = _stringCalculator.Add("7 3");
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Number_With_Positive_Sign_Returns_Number()
        {
            var result = _stringCalculator.Add("+13230");
            Assert.AreEqual(result, 13230);
        }

        [TestMethod]
        public void Number_With_Negative_Sign_Returns_Negative_Number()
        {
            var result = _stringCalculator.Add("-11");
            Assert.AreEqual(result, -11);
        }
    }
}
