using System.Collections.Generic;

namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        public string ConvertNumberToNumeral(int number)
        {
            switch (number)
            {
                case 500: return "D";
                case 50: return "L";
                case 9: return "IX";
                case 5: return "V";
                case 4: return "IV";
                default: break;
            }

            var numeralToNumberMapping = new Dictionary<int, string> {
                { 1000, "M" },
                { 100, "C" },
                { 10, "X" },
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
