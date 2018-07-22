using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;
using Gilded.Rose.Factories;
using Gilded.Rose.Services;
using Gilded.Rose.Services.Calculators;
using Gilded.Rose.Services.Calculators.Validators;
using SimpleInjector;

namespace Gilded.Rose
{
    public class DependencyResolver
    {
        public static Container Container { get; private set; }

        public static void Setup( )
        {
            Container = new Container();

            Container.RegisterInstance<ICalculatorsFactory>(new CalculatorsFactory
            {
                {"agedbrie", () => Container.GetInstance<AgedBrieCalculator>()},
                {"backstagepasses", () => Container.GetInstance<BackStagePassesCalculator>()},
                {"conjured", () => Container.GetInstance<ConjuredCalculator>()},
                {"normalitem", () => Container.GetInstance<NormalItemCalculator>()},
                {"sulfuras", () => Container.GetInstance<SulfurasCalculator>()},



            });

            Container.Register<IStockUpdater, StockUpdater>();
            Container.Register<IQualityValidator,QualityValidator>();
            

            Container.Verify();
        }

        public static T Get<T>() where T : class
        {
            if (Container == null) throw new InvalidOperationException("Cannot resolve dependencies before the container has been initialized.");
            return Container.GetInstance<T>();
        }
    }
}
