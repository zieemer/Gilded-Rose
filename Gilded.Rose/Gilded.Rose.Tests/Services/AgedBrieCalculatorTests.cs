using System;
using System.Text;
using System.Collections.Generic;
using Gilded.Rose.Models;
using Gilded.Rose.Services;
using Gilded.Rose.Services.Calculators;
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
        public void ShouldCalulateInventory(int sellIn, int quality, int expSellIn, int expQuality)
        {
            var sut = new AgedBrieCalculator();

            var resultQuality = sut.CalculateQuality(sellIn, quality);
            var resultSellIn = sut.CalculateSellIn(sellIn);

            Assert.AreEqual(expSellIn, resultSellIn);
            Assert.AreEqual(expQuality, resultQuality);

        }

    }
}
