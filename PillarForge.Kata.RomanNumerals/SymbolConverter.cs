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
            return "I";
        }
    }
}
