using Gilded.Rose.Models;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
            var sut = new StockItem("Normal Item", sellIn, quality);

            sut.Update();

            Assert.AreEqual(resultSellIn, sut.SellIn);
            Assert.AreEqual(resultQuality, sut.Quality);

        }

    }
}
