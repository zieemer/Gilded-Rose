using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Calculators
{
    public class SulfurasCalculator : ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            return quality;
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn;
        }
    }
}