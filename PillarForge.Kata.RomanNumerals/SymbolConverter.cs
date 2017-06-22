using System.Collections.Generic;

namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        public string ConvertNumberToNumeral(int number)
        {
            var numeralToNumberMapping = new Dictionary<int, string> {
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
            var result = "";
            foreach (var mapping in numeralToNumberMapping)
            {
                while (number >= mapping.Key)
                {
                    result += mapping.Value;
                    number -= mapping.Key;
                }
            }

            return result;
        }
    }
}
