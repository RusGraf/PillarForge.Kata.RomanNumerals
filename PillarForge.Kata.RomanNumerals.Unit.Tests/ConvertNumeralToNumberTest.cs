using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarForge.Kata.RomanNumerals.Exceptions;

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

        [TestMethod]
        public void GivenNumeralC_WhenConvertNumeralToNumber_ThenReturnNumberHundred()
        {
            var actual = _target.ConvertNumeralToNumber("C");
            Assert.AreEqual(100, actual);
        }

        [TestMethod]
        public void GivenNumeralD_WhenConvertNumeralToNumber_ThenReturnNumberFiveHundred()
        {
            var actual = _target.ConvertNumeralToNumber("D");
            Assert.AreEqual(500, actual);
        }

        [TestMethod]
        public void GivenNumeralM_WhenConvertNumeralToNumber_ThenReturnNumberThousand()
        {
            var actual = _target.ConvertNumeralToNumber("M");
            Assert.AreEqual(1000, actual);
        }

        [TestMethod]
        public void GivenNumeralII_WhenConvertNumeralToNumber_ThenReturnNumberTwo()
        {
            var actual = _target.ConvertNumeralToNumber("II");
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void GivenNumeralIII_WhenConvertNumeralToNumber_ThenReturnNumberThree()
        {
            var actual = _target.ConvertNumeralToNumber("III");
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void GivenNumeralXXX_WhenConvertNumeralToNumber_ThenReturnNumberThirty()
        {
            var actual = _target.ConvertNumeralToNumber("XXX");
            Assert.AreEqual(30, actual);
        }

        [TestMethod]
        public void GivenNumeralCCC_WhenConvertNumeralToNumber_ThenReturnNumberThreeHundred()
        {
            var actual = _target.ConvertNumeralToNumber("CCC");
            Assert.AreEqual(300, actual);
        }

        [TestMethod]
        public void GivenNumeralMMM_WhenConvertNumeralToNumber_ThenReturnNumberThreeThousand()
        {
            var actual = _target.ConvertNumeralToNumber("MMM");
            Assert.AreEqual(3000, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVV_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            var actual = _target.ConvertNumeralToNumber("VV");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralXVV_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            var actual = _target.ConvertNumeralToNumber("XVV");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralLL_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            var actual = _target.ConvertNumeralToNumber("LL");
        }
    }
}
