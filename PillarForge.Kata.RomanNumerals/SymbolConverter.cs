﻿using System.Collections.Generic;

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
            switch (numeral)
            {
                case "D": return 500;
                case "C": return 100;
                case "L": return 50;
                case "X": return 10;
                case "V": return 5;
                default: return 1;
            }
        }
    }
}
