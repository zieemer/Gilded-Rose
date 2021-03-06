﻿using System;
using Gilded.Rose.Factories;
using Gilded.Rose.Services.Calculators;

using NUnit.Framework;


namespace Gilded.Rose.Tests.Factories
{
    [TestFixture]
    public class StockFactoryTest
    {


        [SetUp]
        public void Init()
        {
            DependencyResolver.Setup();
        }

        [TestCase("NormalItem", typeof(NormalItemCalculator))]
        [TestCase("Sulfuras", typeof(SulfurasCalculator))]
        public void ShouldFactoryReturnCalculator(string stockItemName, Type type )
        {
            var sut = DependencyResolver.Get<ICalculatorsFactory>();

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
