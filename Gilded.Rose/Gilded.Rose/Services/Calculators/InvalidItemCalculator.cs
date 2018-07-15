using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Updaters
{
    public class InvalidItemCalculator : ICalculator
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