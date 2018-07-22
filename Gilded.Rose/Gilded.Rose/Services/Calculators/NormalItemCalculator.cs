using Gilded.Rose.Conracts;
using Gilded.Rose.Services.Calculators.Validators;

namespace Gilded.Rose.Services.Calculators
{
    public class NormalItemCalculator : QualityValidator,  ICalculator
    {
        

        public int CalculateQuality(int sellIn, int quality)
        {
            if (sellIn > 0)
            {
                return ValidateQuality(quality - 1);
            }
            else
            {
                return ValidateQuality(quality - 2);

            }
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }


    }
}