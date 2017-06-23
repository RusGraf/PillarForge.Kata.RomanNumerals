using PillarForge.Kata.RomanNumerals.Exceptions;
using System.Collections.Generic;

namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        private Dictionary<int, string> _numeralToNumberMapping = new Dictionary<int, string> {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string ConvertNumberToNumeral(int number)
        {
            var result = "";
            foreach (var mapping in _numeralToNumberMapping)
            {
                while (number >= mapping.Key)
                {
                    result += mapping.Value;
                    number -= mapping.Key;
                }
            }

            return result;
        }

        public int ConvertNumeralToNumber(string numeral)
        {
            if (!IsRomanNumeralValid(numeral))
            {
                throw new InvalidRomanNumeralInputException();
            }

            var result = 0;
            var numeralCharacters = numeral.ToCharArray();
            foreach (var numeralCharacter in numeralCharacters)
            {
                result += ConvertNumeralCharacterToNumber(numeralCharacter);
            }

            return result;
        }

        private int ConvertNumeralCharacterToNumber(char numeralCharacter)
        {
            switch (numeralCharacter)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I' : return 1;
                default: throw new InvalidRomanNumeralInputException();
            }
        }

        private bool IsRomanNumeralValid(string numeral)
        {
            string[] InvalidExpressions = { "VV", "LL", "DD", "IIII", "XXXX", "CCCC", "MMMM", "IL", "IC", "ID" , "IM", "VX", "VL", "VC", "VD", "VM", "XD", "XM" };
            foreach (var invalidExpression in InvalidExpressions)
            {
                if (numeral.Contains(invalidExpression))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
