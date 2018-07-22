using Gilded.Rose.Models;
using Gilded.Rose.Services;
using Gilded.Rose.Services.Calculators;
using NUnit.Framework;


namespace Gilded.Rose.Tests.Services
{
    /// <summary>
    /// Summary description for NormalItemCalculatorTests
    /// </summary>
    [TestFixture]
    public class BackStagePassesCalculatorTest
    {
        


        [TestCase(11, 10, 10,11)]
        [TestCase(10, 2, 9, 4)]
        [TestCase(5, 2, 4, 5)]
        [TestCase(0, 10, -1, 0)]
        public void ShouldCalulateInventory(int sellIn, int quality, int expResultSellIn, int expResultQuality)
        {
            var item = new StockItem("Backstage Passes", sellIn, quality);

            var sut = new BackStagePassesCalculator();

            var resultQuality =  sut.CalculateQuality(sellIn, quality);
            var resultSellIn = sut.CalculateSellIn(sellIn);


            Assert.AreEqual(expResultSellIn, resultSellIn);
            Assert.AreEqual(expResultQuality, resultQuality);

        }

    }
}
