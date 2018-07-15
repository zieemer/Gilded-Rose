﻿using Gilded.Rose.Models;
using Gilded.Rose.Services;
using NUnit.Framework;


namespace Gilded.Rose.Tests.Services
{
    /// <summary>
    /// Summary description for NormalItemCalculatorTests
    /// </summary>
    [TestFixture]
    public class NormalItemCalculatorTests
    {
       

        
       


        [TestCase(-1, 55, -2,50)]
        [TestCase(2, 2, 1, 1)]

        public void ShouldCalulateInventory(int sellIn, int quality, int resultSellIn, int resultQuality)
        {
            var item = new StockItem("Normal Item", sellIn, quality);

            var sut = new StockUpdater();
            sut.Update(item);

            Assert.AreEqual(resultSellIn, item.SellIn);
            Assert.AreEqual(resultQuality, item.Quality);

        }

    }
}
