using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Calculators
{
    public class BackStagePassesCalculator : ICalculator
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

            return quality;
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}