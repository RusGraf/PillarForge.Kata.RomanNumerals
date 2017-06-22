using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void GivenNumberOne_WhenConvertNumberToNumeral_ThenReturnNumeralI()
        {
            var target = new SymbolConverter();
            var actual = target.ConvertNumberToNumeral(1);
            Assert.AreEqual("I", actual);
        }

        [TestMethod]
        public void GivenNumberFive_WhenConvertNumberToNumeral_ThenReturnNumeralV()
        {
            var target = new SymbolConverter();
            var actual = target.ConvertNumberToNumeral(5);
            Assert.AreEqual("V", actual);
        }

        [TestMethod]
        public void GivenNumberTen_WhenConvertNumberToNumeral_ThenReturnNumeralX()
        {
            var target = new SymbolConverter();
            var actual = target.ConvertNumberToNumeral(10);
            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void GivenNumberFifty_WhenConvertNumberToNumeral_ThenReturnNumeralL()
        {
            var target = new SymbolConverter();
            var actual = target.ConvertNumberToNumeral(50);
            Assert.AreEqual("L", actual);
        }

        [TestMethod]
        public void GivenNumberHundred_WhenConvertNumberToNumeral_ThenReturnNumeralC()
        {
            var target = new SymbolConverter();
            var actual = target.ConvertNumberToNumeral(100);
            Assert.AreEqual("C", actual);
        }
    }
}
