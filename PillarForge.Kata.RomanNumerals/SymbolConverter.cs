namespace PillarForge.Kata.RomanNumerals
{
    public class SymbolConverter
    {
        public string ConvertNumberToNumeral(int number)
        {
            if (number == 5)
            {
                return "V";
            }
            else if (number == 10)
            {
                return "X";
            }
            return "I";
        }
    }
}
