using System;
using Gilded.Rose.Factories;
using Gilded.Rose.Services.Updaters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Gilded.Rose.Tests.Factories
{
    [TestFixture]
    public class StockFactoryTest
    {
        [TestCase("NormalItem", typeof(NormalItemCalculator))]
        [TestCase("Sulfuras", typeof(SulfurasCalculator))]
        [TestCase("InvalidItem", typeof(InvalidItemCalculator))]
        public void ShouldFactoryReturnCalculator(string stockItemName, Type type )
        {
            var sut = new CalculatorsFactory();

            var normalItemUpdater = sut.GetInstance(stockItemName);

            Assert.IsInstanceOfType(normalItemUpdater, type);
        }

       
    }
}
