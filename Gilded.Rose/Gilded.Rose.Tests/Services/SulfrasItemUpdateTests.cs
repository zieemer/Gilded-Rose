using Gilded.Rose.Models;
using Gilded.Rose.Services;
using NUnit.Framework;


namespace Gilded.Rose.Tests.Services
{
    /// <summary>
    /// Summary description for NormalItemCalculatorTests
    /// </summary>
    [TestFixture]
    public class SulfrasItemUpdateTests
    {
       


        [TestCase(2, 55, 2,50)]
        [TestCase(2, 2, 2, 2)]

        public void ShouldCalulateInventory(int sellIn, int quality, int resultSellIn, int resultQuality)
        {
            var item = new StockItem("Sulfuras", sellIn, quality);

            var sut = new StockUpdater();
            sut.Update(item);

            Assert.AreEqual(resultSellIn, item.SellIn);
            Assert.AreEqual(resultQuality, item.Quality);

        }

    }
}
