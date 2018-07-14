namespace Gilded.Rose.Conracts
{
    public interface ICalculator
    {
        int CalculateQuality(int sellIn, int quality);
        int CalculateSellIn(int sellIn);
    }
}