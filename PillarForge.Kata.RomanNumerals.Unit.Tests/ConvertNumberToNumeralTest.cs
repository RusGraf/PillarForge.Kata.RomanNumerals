﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PillarForge.Kata.RomanNumerals.Unit.Tests
{
    [TestClass]
    public class ConvertNumberToNumeralTest
    {
        //Feature: As a game developer
        //I want to be able to convert a number to a numeral
        //So that I can label my game releases using Roman numerals
        //Scenario: Given I have started the converter
        //When I enter $number
        //Then $numeral is returned

        SymbolConverter _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new SymbolConverter();
        }

        [TestMethod]
        public void GivenNumberOne_WhenConvertNumberToNumeral_ThenReturnNumeralI()
        {
            var actual = _target.ConvertNumberToNumeral(1);
            Assert.AreEqual("I", actual);
        }

        [TestMethod]
        public void GivenNumberFive_WhenConvertNumberToNumeral_ThenReturnNumeralV()
        {
            var actual = _target.ConvertNumberToNumeral(5);
            Assert.AreEqual("V", actual);
        }

        [TestMethod]
        public void GivenNumberTen_WhenConvertNumberToNumeral_ThenReturnNumeralX()
        {
            var actual = _target.ConvertNumberToNumeral(10);
            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void GivenNumberFifty_WhenConvertNumberToNumeral_ThenReturnNumeralL()
        {
            var actual = _target.ConvertNumberToNumeral(50);
            Assert.AreEqual("L", actual);
        }

        [TestMethod]
        public void GivenNumberHundred_WhenConvertNumberToNumeral_ThenReturnNumeralC()
        {
            var actual = _target.ConvertNumberToNumeral(100);
            Assert.AreEqual("C", actual);
        }

        [TestMethod]
        public void GivenNumberFiveHundred_WhenConvertNumberToNumeral_ThenReturnNumeralD()
        {
            var actual = _target.ConvertNumberToNumeral(500);
            Assert.AreEqual("D", actual);
        }

        [TestMethod]
        public void GivenNumberThousand_WhenConvertNumberToNumeral_ThenReturnNumeralM()
        {
            var actual = _target.ConvertNumberToNumeral(1000);
            Assert.AreEqual("M", actual);
        }

        [TestMethod]
        public void GivenNumberTwo_WhenConvertNumberToNumeral_ThenReturnNumeralII()
        {
            var actual = _target.ConvertNumberToNumeral(2);
            Assert.AreEqual("II", actual);
        }

        [TestMethod]
        public void GivenNumberThree_WhenConvertNumberToNumeral_ThenReturnNumeralII()
        {
            var actual = _target.ConvertNumberToNumeral(3);
            Assert.AreEqual("III", actual);
        }

        [TestMethod]
        public void GivenNumberTwenty_WhenConvertNumberToNumeral_ThenReturnNumeralXX()
        {
            var actual = _target.ConvertNumberToNumeral(20);
            Assert.AreEqual("XX", actual);
        }

        [TestMethod]
        public void GivenNumberFour_WhenConvertNumberToNumeral_ThenReturnNumeralIV()
        {
            var actual = _target.ConvertNumberToNumeral(4);
            Assert.AreEqual("IV", actual);
        }

        [TestMethod]
        public void GivenNumberNine_WhenConvertNumberToNumeral_ThenReturnNumeralIX()
        {
            var actual = _target.ConvertNumberToNumeral(9);
            Assert.AreEqual("IX", actual);
        }

        [TestMethod]
        public void GivenNumberThreeHundred_WhenConvertNumberToNumeral_ThenReturnNumeralCCC()
        {
            var actual = _target.ConvertNumberToNumeral(300);
            Assert.AreEqual("CCC", actual);
        }

        [TestMethod]
        public void GivenNumberThreeThousand_WhenConvertNumberToNumeral_ThenReturnNumeralMMM()
        {
            var actual = _target.ConvertNumberToNumeral(3000);
            Assert.AreEqual("MMM", actual);
        }

        [TestMethod]
        public void GivenNumberForty_WhenConvertNumberToNumeral_ThenReturnNumeralXL()
        {
            var actual = _target.ConvertNumberToNumeral(40);
            Assert.AreEqual("XL", actual);
        }

        [TestMethod]
        public void GivenNumberNinety_WhenConvertNumberToNumeral_ThenReturnNumeralXC()
        {
            var actual = _target.ConvertNumberToNumeral(90);
            Assert.AreEqual("XC", actual);
        }

        [TestMethod]
        public void GivenNumberFourHundred_WhenConvertNumberToNumeral_ThenReturnNumeralCD()
        {
            var actual = _target.ConvertNumberToNumeral(400);
            Assert.AreEqual("CD", actual);
        }

        [TestMethod]
        public void GivenNumberNineHundred_WhenConvertNumberToNumeral_ThenReturnNumeralCM()
        {
            var actual = _target.ConvertNumberToNumeral(900);
            Assert.AreEqual("CM", actual);
        }

        [TestMethod]
        public void GivenNumberEight_WhenConvertNumberToNumeral_ThenReturnNumeralVIII()
        {
            var actual = _target.ConvertNumberToNumeral(8);
            Assert.AreEqual("VIII", actual);
        }

        [TestMethod]
        public void GivenNumberTwelve_WhenConvertNumberToNumeral_ThenReturnNumeralXII()
        {
            var actual = _target.ConvertNumberToNumeral(12);
            Assert.AreEqual("XII", actual);
        }

        [TestMethod]
        public void GivenNumberOneThousandSixtySix_WhenConvertNumberToNumeral_ThenReturnNumeralMLXVI()
        {
            var actual = _target.ConvertNumberToNumeral(1066);
            Assert.AreEqual("MLXVI", actual);
        }

        [TestMethod]
        public void GivenNumberOneThousandNineHundredEightyNine_WhenConvertNumberToNumeral_ThenReturnNumeralMCMLXXXIX()
        {
            var actual = _target.ConvertNumberToNumeral(1989);
            Assert.AreEqual("MCMLXXXIX", actual);
        }
    }
}
