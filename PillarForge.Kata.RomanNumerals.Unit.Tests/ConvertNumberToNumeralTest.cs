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
    }
}
