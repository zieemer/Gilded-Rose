using System;
using System.Text;
using System.Collections.Generic;
using Gilded.Rose.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

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
            var sut = new StockItem("Aged Brie", sellIn, quality);

            sut.Update();

            Assert.AreEqual(resultSellIn, sut.SellIn);
            Assert.AreEqual(resultQuality, sut.Quality);

        }

    }
}
