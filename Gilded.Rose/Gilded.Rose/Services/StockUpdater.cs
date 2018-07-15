using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;
using Gilded.Rose.Models;
using Gilded.Rose.Services.Validators;

namespace Gilded.Rose.Services
{
    public class StockUpdater
    {
        
        private readonly IQualityValidator _validator;
        private readonly CalculatorsFactory _factory;

        public StockUpdater()
        {
            _validator = new QualityValidator();
            _factory = new CalculatorsFactory();
        }

        private int ValidateQuality(int value)
        {
            return _validator.ValidateQuality(value);
        }


        public string Update(StockItem item)
        {

            var calculator = _factory.GetInstance(item.Name);

            if (calculator != null)
            {
                item.Quality = ValidateQuality(calculator.CalculateQuality(item.SellIn, item.Quality));
                item.SellIn = calculator.CalculateSellIn(item.SellIn);
                return ($"{item.Name} {item.SellIn} {item.Quality}");
            }
            else
            {
                return "NO SUCH ITEM";
            }

        }
    }
}
