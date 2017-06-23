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
            _target.ConvertNumeralToNumber("VV");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralXVV_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("XVV");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralLL_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("LL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralDD_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("DD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralIIII_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("IIII");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralXXXX_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("XXXX");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralCCCC_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("CCCC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralMMMM_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("MMMM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenInvalidNumeralCharacter_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("A");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralIL_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("IL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralIC_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("IC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralID_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("ID");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralIM_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("IM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVX_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("VX");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVL_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("VL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVC_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("VC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVD_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("VD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralVM_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("VM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralXD_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("XD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralXM_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("XM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralLC_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("LC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralInputException))]
        public void GivenNumeralLD_WhenConvertNumeralToNumber_ThenThrowInvalidRomanNumeralInputException()
        {
            _target.ConvertNumeralToNumber("LD");
        }
    }
}
