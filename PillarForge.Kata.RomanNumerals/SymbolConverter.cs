namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        public string ConvertNumberToNumeral(int number)
        {
            switch (number)
            {
                case 50: return "L";
                case 10: return "X";
                case 5: return "V";
                default: break;
            }

            return "I";
        }
    }
}
