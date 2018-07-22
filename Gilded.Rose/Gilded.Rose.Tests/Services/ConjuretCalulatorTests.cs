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
    public class ConjuretCalulatorTests
    {



        [TestCase(2, 2, 1, 0)]
        [TestCase(-1, 5, -2, 1)]

        public void ShouldCalulateInventory(int sellIn, int quality, int expSellIn, int expQuality)
        {


            var sut = new ConjuredCalculator();

            var resultQuality = sut.CalculateQuality(sellIn, quality);
            var resultSellIn = sut.CalculateSellIn(sellIn);

            Assert.AreEqual(expSellIn, resultSellIn);
            Assert.AreEqual(expQuality, resultQuality);

        }

    }
}
