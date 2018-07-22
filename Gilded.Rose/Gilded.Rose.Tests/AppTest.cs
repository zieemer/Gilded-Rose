using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Models;
using Gilded.Rose.Services;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Gilded.Rose.Tests
{
    [TestFixture]
    public class AppTest
    {
        private IStockUpdater sut;

        [SetUp]
        public void Init()
        {
            DependencyResolver.Setup();
            sut = DependencyResolver.Get<IStockUpdater>();
           
        }

        [TestCase("Aged Brie",1,1, "Aged Brie 0 2")]
        [TestCase("Backstage passes",-1,2, "Backstage passes -2 0")]
        [TestCase("Backstage passes", 9, 2, "Backstage passes 8 4")]
        [TestCase("Sulfuras",2,2, "Sulfuras 2 2")]
        [TestCase("Normal Item",-1,55, "Normal Item -2 50")]
        [TestCase("Normal Item", 2, 2, "Normal Item 1 1")]
        [TestCase("Invalid Item", 2, 2, "NO SUCH ITEM")]
        [TestCase("Conjured", 2, 2, "Conjured 1 0")]
        [TestCase("Conjured", -1, 5, "Conjured -2 1")]

        public void ShouldUpdateStock(string name, int sellIn, int qulity, string updateResult)
        {
            // arrange  
            var stockItem = new StockItem(name, sellIn, qulity);
            var result = sut.Update(stockItem);

            // act 
            // assert 
            Assert.AreEqual(updateResult, result);
        }
    }
}
