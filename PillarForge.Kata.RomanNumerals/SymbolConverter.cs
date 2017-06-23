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
                throw new InvalidRomanNumeralInputException("The Roman Numeral input expression is invalid;");
            }

            var result = 0;
            var numeralCharacters = numeral.ToCharArray();
            var characterCount = numeralCharacters.Length;
            for (var i = 0; i < characterCount; i++)
            {
                var numeralCharacter = numeralCharacters[i];
                if (!_numberToNumeralMapping.ContainsKey(numeralCharacter))
                {
                    throw new InvalidRomanNumeralInputException("Only valid Roman Numerals allowed.");
                }
                var currentNumber = _numberToNumeralMapping[numeralCharacter];
                if (IsLastCharacter(i, characterCount))
                {
                    result += currentNumber;
                    return result;
                }
                var nextCarachter = numeralCharacters[i + 1];
                var nextNumber = _numberToNumeralMapping[nextCarachter];
                if (IsNumberShouldBeSubtracted(currentNumber, nextNumber))
                {
                    if (!IsFirstCharacter(i))
                    {
                        var previoseCharacter = numeralCharacters[i - 1];
                        if (previoseCharacter == numeralCharacter)
                        {
                            throw new InvalidRomanNumeralInputException("Only one subtraction can be made per numeral.");
                        }
                    }
                    result -= currentNumber;
                }
                else
                {
                    result += currentNumber;
                }
            }

            return result;
        }

        private bool IsLastCharacter(int characterIndex, int characterCount)
        {
            if (characterIndex + 1 == characterCount)
            {
                return true;
            }
            return false;
        }

        private bool IsFirstCharacter(int characterIndex)
        {
            if (characterIndex == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsRomanNumeralValid(string numeral)
        {
            string[] InvalidExpressions = { "VV", "LL", "DD", "IIII", "XXXX", "CCCC", "MMMM", "VX", "VL", "VC", "VD", "VM", "LC", "LD", "LM", "DM" };
            foreach (var invalidExpression in InvalidExpressions)
            {
                if (numeral.Contains(invalidExpression))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsNumberShouldBeSubtracted(int currentNumber, int nextNumber)
        {
            if (currentNumber < nextNumber)
            {
                if (IsAllowedSubtraction(currentNumber, nextNumber))
                {
                    return true;
                }
                else
                {
                    throw new InvalidRomanNumeralInputException("Not allowed Roman Numeral subtraction.");
                }
            }
            return false;
        }

        private bool IsAllowedSubtraction(int currentNumber, int nextNumber)
        {
            for(var i = 1; i<=100; i *= 10)
            {
                if (currentNumber == i)
                {
                    if (nextNumber == i*5 || nextNumber == i*10)
                    {
                        return true;
                    }
                    return false;
                }
            }
            
            return true;
        }
    }
}
