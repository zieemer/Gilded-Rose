using Gilded.Rose.Models;
using Gilded.Rose.Services;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Gilded.Rose.Tests.Services
{
    /// <summary>
    /// Summary description for NormalItemCalculatorTests
    /// </summary>
    [TestFixture]
    public class ConjuretCalulatorTests
    {
       


        [TestCase(2, 2, 1,0)]
        [TestCase(-1, 5, -2, 1)]

        public void ShouldCalulateInventory(int sellIn, int quality, int resultSellIn, int resultQuality)
        {
            var item = new StockItem("Conjured", sellIn, quality);

            var sut = new StockUpdater();
            sut.Update(item);

            Assert.AreEqual(resultSellIn, item.SellIn);
            Assert.AreEqual(resultQuality, item.Quality);

        }

    }
}
