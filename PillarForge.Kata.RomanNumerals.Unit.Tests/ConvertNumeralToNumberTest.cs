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

        [TestMethod]
        public void GivenNumeralI_WhenConvertNumeralToNumber_ThenReturnNumberOne()
        {
            SymbolConverter target = new SymbolConverter();
            var actual = target.ConvertNumeralToNumber("I");
            Assert.AreEqual(1, actual);
        }
    }
}
