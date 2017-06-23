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
        private Dictionary<char, int> _numberToNumeralMapping = new Dictionary<char, int> {
            { 'M', 1000 },
            { 'D', 500 },
            { 'C', 100 },
            { 'L', 50 },
            { 'X', 10 },
            { 'V', 5 },
            { 'I', 1 }
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
            var previousNumber = 0;
            var numeralCharacters = numeral.ToCharArray();
            foreach (var numeralCharacter in numeralCharacters)
            {
                if (!_numberToNumeralMapping.ContainsKey(numeralCharacter))
                {
                    throw new InvalidRomanNumeralInputException();
                }

                var currentNumber = _numberToNumeralMapping[numeralCharacter];
                result += currentNumber;
                if (IsPrevioseNumberSubtracted(currentNumber, previousNumber))
                {
                    result -= previousNumber * 2;
                }
                previousNumber = currentNumber;
            }

            return result;
        }
        
        private bool IsRomanNumeralValid(string numeral)
        {
            string[] InvalidExpressions = { "VV", "LL", "DD", "IIII", "XXXX", "CCCC", "MMMM", "IL", "IC", "ID",
                "IM", "VX", "VL", "VC", "VD", "VM", "XD", "XM", "LC", "LD", "LM", "DM" };
            foreach (var invalidExpression in InvalidExpressions)
            {
                if (numeral.Contains(invalidExpression))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPrevioseNumberSubtracted(int currentNumber, int previousNumber)
        {
            if (previousNumber != 0 && previousNumber < currentNumber)
            {
                if (previousNumber == 1 && (currentNumber == 5 || currentNumber == 10)
                    || (previousNumber == 10 && (currentNumber == 50 || currentNumber == 100))
                    || (previousNumber == 100 && (currentNumber == 500 || currentNumber == 1000)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
