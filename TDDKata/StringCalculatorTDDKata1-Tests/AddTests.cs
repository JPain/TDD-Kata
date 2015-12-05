using System;
using System.Collections.Generic;
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
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Numberless_String_Returns_0()
        {
            var result = _stringCalculator.Add("This is a String with no numbers");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void One_Number_String_Returns_Sum()
        {
            var result = _stringCalculator.Add("4");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void One_Number_String_With_Whitespace_Returns_Sum()
        {
            var result = _stringCalculator.Add("  4  ");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Two_Comma_Sepearted_Numbers_Returns_Sum()
        {
            var result = _stringCalculator.Add("2,4");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Three_Comma_Seperated_Numbers_Returns_Sum()
        {
            var result = _stringCalculator.Add("2,4,6");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Space_Seperated_Numbers_Return_0()
        {
            var result = _stringCalculator.Add("7 3");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Number_With_Positive_Sign_Returns_Number()
        {
            var result = _stringCalculator.Add("+13230");
            Assert.AreEqual(13230, result);
        }

        [TestMethod]
        public void Number_With_Negative_Sign_Returns_Negative_Number()
        {
            var result = _stringCalculator.Add("-11");
            Assert.AreEqual(-11, result);
        }

        [TestMethod]
        public void Two_Negative_Numbers_Returns_Negative_Sum()
        {
            var result = _stringCalculator.Add("-11,-2");
            Assert.AreEqual(-13, result);
        }

        [TestMethod]
        public void Decimal_Number_Returns_Floored_Sum()
        {
            var result = _stringCalculator.Add("134985.5");
            Assert.AreEqual(134985, result);
        }

        [TestMethod]
        public void Two_Decimal_Number_Returns_Floored_Sum()
        {
            var result = _stringCalculator.Add("134985.1,1385.2");
            Assert.AreEqual(136370, result);
        }

        [TestMethod]
        public void Naughty_Strings_Return_0()
        {
            foreach (var naughtyString in NaughtyStrings.ListOfStrings)
            {
                var result = _stringCalculator.Add(naughtyString);
                if (result != 0)
                {
                    Assert.Fail("Failed input string: " + naughtyString + " Result: " + result);
                }
            }
        }

        [TestMethod]
        public void Large_Amount_Of_Numbers_Returns_Sum()
        {
            var queryString = "";
            var expected = 0;
            var rnd = new Random();
            var finishTime = DateTimeOffset.Now.AddSeconds(1);

            while (DateTime.Now < finishTime)
            {
                if (queryString != "")
                    queryString += ",";

                var gen = rnd.Next(-999999999, 999999999);
                expected += gen;
                queryString += gen;
            }

            var result = _stringCalculator.Add(queryString);
            Assert.AreEqual(expected, result);

        }
    }
}