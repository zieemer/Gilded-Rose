using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;
using Gilded.Rose.Services.Validators;

namespace Gilded.Rose.Models
{
    public class StockItem
    {
       
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
       
        public StockItem(string name, int sellIn, int quality)
        {
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }


       
    }
}
