using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Models;
using Gilded.Rose.Services;

namespace Gilded.Rose
{
    class Program
    {
        static void Main(string[] args)
        {
            var updater = new StockUpdater();
            var items = new List<StockItem>()
            {
                new StockItem("AgedBrie",1,1),
                new StockItem("BackStagePasses",-1,2),
                new StockItem("BackStagePasses",9,2),
                new StockItem("Sulfuras",2,2),
                new StockItem("NormalItem",-1,55),
                new StockItem("NormalItem",2,2),
                new StockItem("INVALID ITEM",2,2),
                new StockItem("Conjured",2,2),
                new StockItem("Conjured",-1,5),

               
            };

           

            foreach (var stockItem in items)
            {
               Console.WriteLine(updater.Update(stockItem));
            }

            Console.ReadKey();
        }
    }
}
