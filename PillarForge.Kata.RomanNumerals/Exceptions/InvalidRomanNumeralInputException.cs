using System;

namespace PillarForge.Kata.RomanNumerals.Exceptions
{
    public class InvalidRomanNumeralInputException : ArgumentException
    {
        public InvalidRomanNumeralInputException(string message) : base(message)
        {
        }
    }
}
