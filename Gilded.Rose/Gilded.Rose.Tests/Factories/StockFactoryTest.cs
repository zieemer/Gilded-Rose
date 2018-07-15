using System;
using Gilded.Rose.Factories;
using Gilded.Rose.Services.Calculators;

using NUnit.Framework;


namespace Gilded.Rose.Tests.Factories
{
    [TestFixture]
    public class StockFactoryTest
    {
        [TestCase("NormalItem", typeof(NormalItemCalculator))]
        [TestCase("Sulfuras", typeof(SulfurasCalculator))]
        public void ShouldFactoryReturnCalculator(string stockItemName, Type type )
        {
            var sut = new CalculatorsFactory();

            var calculator = sut.GetInstance(stockItemName);

            Assert.IsInstanceOf(type, calculator);
        }

        [Test]
        public void ShouldFacttoryRetunrNullForUnknowType()
        {
            var sut = new CalculatorsFactory();

            var calculator = sut.GetInstance("invalid");

            Assert.IsNull(calculator);
        }
       
    }
}
