using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Calculators
{
    public class AgedBrieCalculator : ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            return quality + 1;
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}