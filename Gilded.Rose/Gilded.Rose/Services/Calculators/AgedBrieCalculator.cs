using Gilded.Rose.Conracts;
using Gilded.Rose.Services.Calculators.Validators;

namespace Gilded.Rose.Services.Calculators
{
    public class AgedBrieCalculator : QualityValidator, ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            return ValidateQuality(quality + 1);
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}