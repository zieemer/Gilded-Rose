using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Updaters
{
    public class NormalItemCalculator : ICalculator
    {
       

        public int CalculateQuality(int sellIn, int quality)
        {
            if (sellIn > 0)
            {
                return quality - 1;
            }
            else
            {
                return quality - 2;

            }
        }

        public int CalculateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}