using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;

namespace Gilded.Rose.Models
{
    public class StockItem
    {
        private readonly ICalculator _updater;
        private readonly IReport _report;

        public string Name { get; private set; }
        public int Quality { get; private set; }
        public int SellIn { get; private set; }
        private readonly CalculatorsFactory factory;
        public StockItem(string name, int sellIn, int quality)
        {
            factory = new CalculatorsFactory();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
            _updater = factory.GetInstance(name);
           // _report = report;

        }







        private int ValidateQuality(int value)
        {
            if (value > 50) return 50;
            if (value < 0) return 0;
            return value;


        }


        public void Update()
        {
            Quality = ValidateQuality(_updater.CalculateQuality(SellIn, Quality));
            SellIn = _updater.CalculateSellIn(SellIn);
           // _report.Print(Name, SellIn, Quality);
        }
    }
}
