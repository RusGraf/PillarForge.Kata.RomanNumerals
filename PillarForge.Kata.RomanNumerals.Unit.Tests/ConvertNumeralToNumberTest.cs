using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PillarForge.Kata.RomanNumerals.Unit.Tests
{
    [TestClass]
    public class ConvertNumeralToNumberTest
    {
        //Feature: As a marketing manager
        //I want customers to be able to convert numerals to numbers
        //So that they can buy the latest version of the game
        //Scenario: Given I have started the converter
        //When I enter $numeral
        //Then $number is returned

        SymbolConverter _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new SymbolConverter();
        }

        [TestMethod]
        public void GivenNumeralI_WhenConvertNumeralToNumber_ThenReturnNumberOne()
        {
            var actual = _target.ConvertNumeralToNumber("I");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void GivenNumeralV_WhenConvertNumeralToNumber_ThenReturnNumberFive()
        {
            var actual = _target.ConvertNumeralToNumber("V");
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void GivenNumeralX_WhenConvertNumeralToNumber_ThenReturnNumberTen()
        {
            var actual = _target.ConvertNumeralToNumber("X");
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void GivenNumeralL_WhenConvertNumeralToNumber_ThenReturnNumberFifty()
        {
            var actual = _target.ConvertNumeralToNumber("L");
            Assert.AreEqual(50, actual);
        }
    }
}
