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
                case 10: return "X";
                case 5: return "V";
                case 2: return "II";
                default: break;
            }

            return "I";
        }
    }
}
