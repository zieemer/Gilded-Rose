using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Factories;
using Gilded.Rose.Models;
using Gilded.Rose.Services;
using Gilded.Rose.Services.Calculators;
using Moq;
using NUnit.Framework;

namespace Gilded.Rose.Tests.Services
{
    [TestFixture]
    public class StockUpdaterTest
    {
        private StockUpdater sut;


        [SetUp]
        public void Init()
        {
            var mockCalculatorsFactory = new Mock<ICalculatorsFactory>();
            mockCalculatorsFactory.Setup(s => s.GetInstance("Normal Item")).Returns(new NormalItemCalculator());

            sut = new StockUpdater(mockCalculatorsFactory.Object);
        }

        [Test]
        public void ShouldStockUpdaterCalulateForNormalItem()
        {
            var stockItem = new StockItem("Normal Item", 2, 2);
            var result = sut.Update(stockItem);

            Assert.AreEqual("Normal Item 1 1", result);
        }
    }
}
