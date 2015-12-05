﻿using System;
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

        [TestMethod]
        public void Add_With_One_Number_String_Returns_0()
        {
            var result = _stringCalculator.Add("4");
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Add_With_Two_Comma_Sepearted_Numbers_Returns_Sum()
        {
            var result = _stringCalculator.Add("2,4");
            Assert.AreEqual(result, 6);
        }
    }
}
