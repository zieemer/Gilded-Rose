using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;
using Gilded.Rose.Models;

namespace Gilded.Rose.Services
{
    public interface IStockUpdater
    {
       

        /// <summary>
        /// Updating stockItem and displaying result
        /// </summary>
        /// <param name="stockItem"></param>
        /// <returns></returns>
        string Update(StockItem stockItem);
    }

    public class StockUpdater : IStockUpdater
    {
        
        
        private readonly ICalculatorsFactory _factory;
       

        public StockUpdater(ICalculatorsFactory factory)
        {
           
            _factory = factory;
        }
        
      
        public string Update(StockItem stockItem)
        {

            var calculator = _factory.GetInstance(stockItem.Name);

            if (calculator != null)
            {
                stockItem.Quality = calculator.CalculateQuality(stockItem.SellIn, stockItem.Quality);
                stockItem.SellIn = calculator.CalculateSellIn(stockItem.SellIn);
                return ($"{stockItem.Name} {stockItem.SellIn} {stockItem.Quality}");
            }
            else
            {
                return "NO SUCH ITEM";
            }

        }
    }
}
