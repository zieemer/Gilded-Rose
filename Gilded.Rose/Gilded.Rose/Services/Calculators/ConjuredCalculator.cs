using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Calculators
{
    public class ConjuredCalculator : ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            quality = sellIn < 0 ? quality - 4 : quality - 2;
            return quality;
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}