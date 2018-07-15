using System;
using System.Text;
using System.Collections.Generic;
using Gilded.Rose.Models;
using Gilded.Rose.Services;

using NUnit.Framework;


namespace Gilded.Rose.Tests
{
    /// <summary>
    /// Summary description for NormalItemCalculatorTests
    /// </summary>
    [TestFixture]
    public class AgedBrieCalculatorTests
    {
       
        
        [TestCase(1, 1, 0, 2)]
        public void ShouldCalulateInventory(int sellIn, int quality, int resultSellIn, int resultQuality)
        {
            var item = new StockItem("Aged Brie", sellIn, quality);

            var sut = new StockUpdater();
            sut.Update(item);

            Assert.AreEqual(resultSellIn, item.SellIn);
            Assert.AreEqual(resultQuality, item.Quality);

        }

    }
}
