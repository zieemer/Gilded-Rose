using Gilded.Rose.Conracts;
using Gilded.Rose.Services.Calculators.Validators;

namespace Gilded.Rose.Services.Calculators
{
    public class ConjuredCalculator : QualityValidator, ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            quality = sellIn < 0 ? quality - 4 : quality - 2;
            return ValidateQuality(quality);
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}