using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;
using Gilded.Rose.Models;
using Gilded.Rose.Services.Validators;

namespace Gilded.Rose.Services
{
    public class StockUpdater
    {
        
        
        private readonly CalculatorsFactory _factory;
        //TODO eventually resolve using IOC
        private readonly IQualityValidator _validator;

        public StockUpdater()
        {
            _validator = new QualityValidator();
            _factory = new CalculatorsFactory();
        }



        private int ValidateQuality(int value)
        {
            return _validator.ValidateQuality(value);
        }


        /// <summary>
        /// Updating stockItem and displaying result
        /// </summary>
        /// <param name="stockItem"></param>
        /// <returns></returns>
        public string Update(StockItem stockItem)
        {

            var calculator = _factory.GetInstance(stockItem.Name);

            if (calculator != null)
            {
                stockItem.Quality = ValidateQuality(calculator.CalculateQuality(stockItem.SellIn, stockItem.Quality));
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
