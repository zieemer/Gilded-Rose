using Gilded.Rose.Conracts;
using Gilded.Rose.Services.Calculators.Validators;

namespace Gilded.Rose.Services.Calculators
{
    public class BackStagePassesCalculator : QualityValidator, ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {

            if (sellIn > 10)
            {
                quality = quality + 1;
            }
            else if (sellIn > 5)
            {
                quality = quality + 2;

            }
            else if (sellIn > 0)
            {
                quality = quality + 3;
            }
            else
            {
                quality = 0;
            }

            return ValidateQuality(quality);
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}