namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        public string ConvertNumberToNumeral(int number)
        {
            switch (number)
            {
                case 1000: return "M";
                case 500: return "D";
                case 100: return "C";
                case 50: return "L";
                case 9: return "IX";
                case 5: return "V";
                case 4: return "IV";
                default: break;
            }
            var result = "";
            while (number >= 10)
            {
                result += "X";
                number -= 10;
            }
            while (number > 0)
            {
                result += "I";
                number--;
            }
            
            return result;
        }
    }
}
